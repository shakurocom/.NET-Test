using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using log4net;
using log4net.Config;

namespace TG.Exam.Refactoring
{
    public class OrderService : IOrderService
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(OrderService));

        readonly string connectionString = ConfigurationManager.ConnectionStrings["OrdersDBConnectionString"].ConnectionString;

        public IDictionary<string, Order> cache = new Dictionary<string, Order>();

        public OrderService()
        {
            BasicConfigurator.Configure();
        }

        public Order LoadOrder(string orderId)
        {
            try
            {
                Debug.Assert(null != orderId && orderId != "");
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                lock (cache)
                {
                    if (cache.ContainsKey(orderId))
                    {
                        stopWatch.Stop();
                        logger.InfoFormat("Elapsed - {0}", stopWatch.Elapsed);
                        return cache[orderId];
                    }
                }
                string queryTemplate =
                  "SELECT OrderId, OrderCustomerId, OrderDate" +
                  "  FROM dbo.Orders where OrderId='{0}'";
                string query = string.Format(queryTemplate, orderId);
                SqlConnection connection =
                  new SqlConnection(this.connectionString);
                SqlCommand command =
                  new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Order order = new Order
                    {
                        OrderId = (int) reader[0],
                        OrderCustomerId = (int) reader[1],
                        OrderDate = (DateTime) reader[2]
                    };

                    lock (cache)
                    {
                        if (!cache.ContainsKey(orderId))
                            cache[orderId] = order;
                    }
                    stopWatch.Stop();
                    logger.InfoFormat("Elapsed - {0}", stopWatch.Elapsed);
                    return order;
                }
                stopWatch.Stop();
                logger.InfoFormat("Elapsed - {0}", stopWatch.Elapsed);
                return null;
            }
            catch (SqlException ex)
            {
                logger.Error(ex.Message);
                throw new ApplicationException("Error");
            }
        }
    }
}

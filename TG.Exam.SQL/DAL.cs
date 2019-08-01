using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.Exam.SQL
{
    public class DAL
    {
        private SqlConnection GetConnection() 
        {
            var connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            var con = new SqlConnection(connectionString);

            con.Open();

            return con;
        }

        private DataSet GetData(string sql)
        {
            var ds = new DataSet();

            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    using (var adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(ds);
                    }
                }
            }

            return ds;
        }

        private void Execute(string sql)
        {
            using (var con = GetConnection())
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllOrders()
        {
            var sql = String.Empty;

            var ds = GetData(sql);

            var result = ds.Tables.OfType<DataTable>().FirstOrDefault();

            return result;
        }
        public DataTable GetAllOrdersWithCustomers()
        {
            var sql = String.Empty;

            var ds = GetData(sql);

            var result = ds.Tables.OfType<DataTable>().FirstOrDefault();

            return result;
        }

        public DataTable GetAllOrdersWithPriceUnder(int price)
        {
            var sql = String.Empty;

            var ds = GetData(sql);

            var result = ds.Tables.OfType<DataTable>().FirstOrDefault();

            return result;
        }

        public void DeleteCustomer(int orderId)
        {
            var sql = String.Empty;

            Execute(sql);
        }

        internal DataTable GetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders()
        {
            var sql = String.Empty;

            var ds = GetData(sql);

            var result = ds.Tables.OfType<DataTable>().FirstOrDefault();

            return result;
        }
    }
}

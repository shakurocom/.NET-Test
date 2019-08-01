using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TG.Exam.SQL
{
    public partial class Form1 : Form
    {
        private DAL DAL { get; set; }

        public Form1()
        {
            InitializeComponent();

            this.DAL = new DAL();
        }

        private void btnShowAllOrders_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = this.DAL.GetAllOrders();
        }

        private void btnShowAllOrdersWithCustomer_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = this.DAL.GetAllOrdersWithCustomers();
        }

        private void btnShowOrderWithTotalPriceUnderX_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = this.DAL.GetAllOrdersWithPriceUnder((int)nudPrice.Value);
        }

        private void btnDeleteCustomerRelatedToOrder_Click(object sender, EventArgs e)
        {
            try 
	        {	        
		        var orderId = (int)(dgvData.SelectedRows[0].Cells[0].Value);

                this.DAL.DeleteCustomer(orderId);

                dgvData.DataSource = this.DAL.GetAllOrdersWithCustomers();
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show("Please select an order before clicking Delete button");
	        }
            
        }

        private void btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var data = this.DAL.GetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders();

            data.Rows.OfType<DataRow>().ToList().ForEach(r => 
            {
                sb.AppendFormat("Item [{0}] - {1} in {2} Orders \r\n", r.Field<int>("ItemId"), r.Field<string>("ItemName"), r.Field<int>("Count"));
            });

            MessageBox.Show(sb.ToString());
        }
    }
}

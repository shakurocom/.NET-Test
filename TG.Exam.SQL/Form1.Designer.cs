namespace TG.Exam.SQL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnShowAllOrdersWithCustomer = new System.Windows.Forms.Button();
            this.btnShowOrderAbove = new System.Windows.Forms.Button();
            this.btnDeleteCustomerRelatedToOrder = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnShowAllOrders = new System.Windows.Forms.Button();
            this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 12);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(445, 256);
            this.dgvData.TabIndex = 0;
            // 
            // btnShowAllOrdersWithCustomer
            // 
            this.btnShowAllOrdersWithCustomer.Location = new System.Drawing.Point(463, 99);
            this.btnShowAllOrdersWithCustomer.Name = "btnShowAllOrdersWithCustomer";
            this.btnShowAllOrdersWithCustomer.Size = new System.Drawing.Size(219, 23);
            this.btnShowAllOrdersWithCustomer.TabIndex = 1;
            this.btnShowAllOrdersWithCustomer.Text = "Show all orders with customer";
            this.btnShowAllOrdersWithCustomer.UseVisualStyleBackColor = true;
            this.btnShowAllOrdersWithCustomer.Click += new System.EventHandler(this.btnShowAllOrdersWithCustomer_Click);
            // 
            // btnShowOrderAbove
            // 
            this.btnShowOrderAbove.Location = new System.Drawing.Point(463, 41);
            this.btnShowOrderAbove.Name = "btnShowOrderAbove";
            this.btnShowOrderAbove.Size = new System.Drawing.Size(149, 23);
            this.btnShowOrderAbove.TabIndex = 2;
            this.btnShowOrderAbove.Text = "Show orders above (>)";
            this.btnShowOrderAbove.UseVisualStyleBackColor = true;
            this.btnShowOrderAbove.Click += new System.EventHandler(this.btnShowOrderWithTotalPriceUnderX_Click);
            // 
            // btnDeleteCustomerRelatedToOrder
            // 
            this.btnDeleteCustomerRelatedToOrder.Location = new System.Drawing.Point(463, 70);
            this.btnDeleteCustomerRelatedToOrder.Name = "btnDeleteCustomerRelatedToOrder";
            this.btnDeleteCustomerRelatedToOrder.Size = new System.Drawing.Size(219, 23);
            this.btnDeleteCustomerRelatedToOrder.TabIndex = 3;
            this.btnDeleteCustomerRelatedToOrder.Text = "Delete customer related to the order";
            this.btnDeleteCustomerRelatedToOrder.UseVisualStyleBackColor = true;
            this.btnDeleteCustomerRelatedToOrder.Click += new System.EventHandler(this.btnDeleteCustomerRelatedToOrder_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(618, 41);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(64, 20);
            this.nudPrice.TabIndex = 4;
            this.nudPrice.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // btnShowAllOrders
            // 
            this.btnShowAllOrders.Location = new System.Drawing.Point(463, 12);
            this.btnShowAllOrders.Name = "btnShowAllOrders";
            this.btnShowAllOrders.Size = new System.Drawing.Size(219, 23);
            this.btnShowAllOrders.TabIndex = 5;
            this.btnShowAllOrders.Text = "Show all orders";
            this.btnShowAllOrders.UseVisualStyleBackColor = true;
            this.btnShowAllOrders.Click += new System.EventHandler(this.btnShowAllOrders_Click);
            // 
            // btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders
            // 
            this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders.Location = new System.Drawing.Point(463, 128);
            this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders.Name = "btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders";
            this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders.Size = new System.Drawing.Size(219, 23);
            this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders.TabIndex = 6;
            this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders.Text = "Display all the items and thier orders count";
            this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders.UseVisualStyleBackColor = true;
            this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders.Click += new System.EventHandler(this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 275);
            this.Controls.Add(this.btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders);
            this.Controls.Add(this.btnShowAllOrders);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.btnDeleteCustomerRelatedToOrder);
            this.Controls.Add(this.btnShowOrderAbove);
            this.Controls.Add(this.btnShowAllOrdersWithCustomer);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnShowAllOrdersWithCustomer;
        private System.Windows.Forms.Button btnShowOrderAbove;
        private System.Windows.Forms.Button btnDeleteCustomerRelatedToOrder;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btnShowAllOrders;
        private System.Windows.Forms.Button btnGetAllItemsAndTheirOrdersCountIncludingTheItemsWithoutOrders;
    }
}


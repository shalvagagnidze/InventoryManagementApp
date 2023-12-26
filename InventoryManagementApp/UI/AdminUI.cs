using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp.UI
{
    public partial class AdminUI : KryptonForm
    {
        public AdminUI()
        {
            InitializeComponent();
            Dashboard_UC dashboard = new Dashboard_UC();
            addUserControl(dashboard);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            
        }


        private void AdminUI_Load(object sender, EventArgs e)
        {
            
        }

        private void home_Btn_Click(object sender, EventArgs e)
        {
            Dashboard_UC dashboard = new Dashboard_UC();
            addUserControl(dashboard);
        }

        private void product_Btn_Click(object sender, EventArgs e)
        {
            Products_UC products_UC = new Products_UC();
            addUserControl(products_UC);
        }

        private void sales_Btn_Click(object sender, EventArgs e)
        {
            Orders_UC salesUC = new Orders_UC();
            addUserControl(salesUC);
        }

        private void invoice_Btn_Click(object sender, EventArgs e)
        {
            Invoice_UC invoiceUC = new Invoice_UC();
            addUserControl(invoiceUC);
        }

        private void settings_Btn_Click(object sender, EventArgs e)
        {
            Costumers_UC settingsUC = new Costumers_UC();
            addUserControl(settingsUC);
        }
    }
}

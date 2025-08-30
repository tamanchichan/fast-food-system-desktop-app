using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fast_food_system_desktop_app.Data;
using fast_food_system_desktop_app.Model;

namespace fast_food_system_desktop_app
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            Customers_Load();
        }

        private void Customers_Load()
        {
            CreateCustomerItems(DataAccess.Customers);
        }

        private void CreateCustomerItems(HashSet<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Panel panel = new Panel();
                panel.AutoScroll = true;
                panel.Dock = DockStyle.Top;
                panel.Width = customersPanel.Width;
                panel.Height = 50;

                Label label = new Label();
                label.Text = customer.Name;

                panel.Controls.Add(label);
                customersPanel.Controls.Add(panel);
            }
        }
    }
}

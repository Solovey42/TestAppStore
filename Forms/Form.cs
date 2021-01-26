using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form : System.Windows.Forms.Form, MainFormInterface
    {
        

        public Form()
        {
            InitializeComponent();
            buttonUpdateOrders.Click += (sender, args) => Invoke(GetDataOrders);
            buttonDeleteOrder.Click += (sender, args) => Invoke(DeleteOrder);
            buttonUpdateOrder.Click += (sender, args) => Invoke(UpdateOrder);
            
        }

        public event Action GetDataOrders;

        public event Action DeleteOrder;

        public event Action UpdateOrder;

        public int OrderIndex { get { return Convert.ToInt32(dataGridView1.CurrentCell.Value); } }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
      
        void MainFormInterface.Show()
        {
            Application.Run(this);
        }

        public void ShowOrders(List<ViewOrder> orders)
        {
            dataGridView1.DataSource = orders;
        }
        private void Invoke(Action action)
        {
            if (action != null) action();

        }
    }
}

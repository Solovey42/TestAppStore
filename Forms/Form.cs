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
            buttonCreateOrder.Click += (sender, args) => Invoke(CreateOrder);
            comboBox1.Click += (sender, args) => Invoke(ChoiceClient);
            comboBox2.Click += (sender, args) => Invoke(ChoiceProduct);

        }

        public event Action GetDataOrders;

        public event Action DeleteOrder;

        public event Action UpdateOrder;

        public event Action CreateOrder;

        public event Action ChoiceClient;

        public event Action ChoiceProduct;

        public int OrderIndex { get { return Convert.ToInt32(dataGridView1.CurrentCell.Value); } }
        public int ClientIndex { get { return comboBox1.SelectedIndex; } }
        public int ProductIndex { get { return comboBox2.SelectedIndex; } }
        public DateTime Date { get { return dateTimePicker1.Value; } }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void AddClientsList(List<String> list)
        {
            comboBox1.DataSource = list;
        }
        public void AddProductsList(List<String> list)
        {
            comboBox2.DataSource = list;
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

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}

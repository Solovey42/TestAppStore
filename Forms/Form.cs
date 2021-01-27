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
    /// <summary>
    /// Класс формы
    /// </summary>
    public partial class Form : System.Windows.Forms.Form, MainFormInterface
    {
        public Form()
        {
            InitializeComponent();
            buttonUpdateOrders.Click += (sender, args) => Invoke(GetDataOrders);
            tabPage1.Click += (sender, args) => Invoke(GetDataProduct);
            tabPage2.Click += (sender, args) => Invoke(GetDataClients);
            buttonCreateOrder.Click += (sender, args) => Invoke(CreateOrder);
            buttonDeleteOrder.Click += (sender, args) => Invoke(DeleteOrder);
            buttonUpdateOrder.Click += (sender, args) => Invoke(UpdateOrder);
            buttonCreateProduct.Click += (sender, args) => Invoke(CreateProduct);
            buttonDeleteProduct.Click += (sender, args) => Invoke(DeleteProduct);
            buttonCreateClient.Click  += (sender, args) => Invoke(CreateClient);
            buttonDeleteClient.Click += (sender, args) => Invoke(DeleteClient);
            comboBox1.Click += (sender, args) => Invoke(ChoiceClient);
            comboBox2.Click += (sender, args) => Invoke(ChoiceProduct);
        }

        public event Action GetDataOrders;

        public event Action GetDataProduct;

        public event Action GetDataClients;

        public event Action CreateOrder;

        public event Action DeleteOrder;

        public event Action UpdateOrder;

        public event Action CreateProduct;

        public event Action DeleteProduct;

        public event Action CreateClient;

        public event Action DeleteClient;

        public event Action ChoiceClient;

        public event Action ChoiceProduct;

        public int OrderIndex { get { return Convert.ToInt32(dataGridView1.CurrentCell.Value); } }
        public int ClientIndex { get { return comboBox1.SelectedIndex; } }
        public int ProductIndex { get { return comboBox2.SelectedIndex; } }
        public DateTime Date { get { return dateTimePicker1.Value; } }
        public int ProductIndexDel { get { return Convert.ToInt32(dataGridView2.CurrentCell.Value); } }
        public string ProductType { get { return textBox1.Text; } }
        public float ProductCost { get { return Convert.ToSingle(textBox2.Text); } }
        public string ProductInfo { get { return textBox3.Text; } }
        public int ClientIndexDel { get { return Convert.ToInt32(dataGridView3.CurrentCell.Value); } }
        public string ClientName { get { return textBox4.Text; } }
        public string ClientPhone { get { return textBox5.Text; } }


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
            Invoke(GetDataProduct);
            Invoke(GetDataClients);
            Application.Run(this);
        }

        public void ShowOrders(List<ViewOrder> orders)
        {
            dataGridView1.DataSource = orders;
        }

        public void ShowProduct(List<ViewProduct> products)
        {
            dataGridView2.DataSource = products;
        }

        public void ShowClient(List<ViewClient> clients)
        {
            dataGridView3.DataSource = clients;
        }
        private void Invoke(Action action)
        {
            if (action != null) action();

        }
    }
}

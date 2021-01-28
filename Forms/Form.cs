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
            buttonUpdateOrders.Click += (sender, args) => InvokeGet(GetDataOrders);
            tabPage1.Click += (sender, args) => InvokeGet(GetDataProduct);
            tabPage2.Click += (sender, args) => InvokeGet(GetDataClients);
            buttonCreateOrder.Click += (sender, args) => InvokeCreate(CreateOrder, dataGridViewOrders);
            buttonDeleteOrder.Click += (sender, args) => InvokeDelete(DeleteOrder, dataGridViewOrders);
            buttonUpdateOrder.Click += (sender, args) => InvokeUpdate(UpdateOrder, dataGridViewOrders);
            buttonCreateProduct.Click += (sender, args) => InvokeCreate(CreateProduct, dataGridViewProducts);
            buttonDeleteProduct.Click += (sender, args) => InvokeDelete(DeleteProduct, dataGridViewProducts);
            buttonCreateClient.Click  += (sender, args) => InvokeCreate(CreateClient, dataGridViewClients);
            buttonDeleteClient.Click += (sender, args) => InvokeDelete(DeleteClient, dataGridViewClients);
            comboBox1.Click += (sender, args) => InvokeGet(ChoiceClient);
            comboBox2.Click += (sender, args) => InvokeGet(ChoiceProduct);
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

        public int OrderIndex { get {  return Convert.ToInt32(dataGridViewOrders.CurrentCell.Value); } }
        public int ClientIndex { get { return comboBox1.SelectedIndex; } }
        public int ProductIndex { get { return comboBox2.SelectedIndex; } }
        public DateTime Date { get { return dateTimePicker1.Value; } }
        public int ProductIndexDel { get { return Convert.ToInt32(dataGridViewProducts.CurrentCell.Value); } }
        public string ProductType { get { return textBox1.Text; } }
        public float ProductCost { get { return Convert.ToSingle(numericUpDown1.Text); } }
        public string ProductInfo { get { return textBox3.Text; } }
        public int ClientIndexDel { get { return Convert.ToInt32(dataGridViewClients.CurrentCell.Value); } }
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
            InvokeGet(GetDataProduct);
            InvokeGet(GetDataClients);
            Application.Run(this);
        }

        public void ShowOrders(List<ViewOrder> orders)
        {
            dataGridViewOrders.DataSource = orders;
        }

        public void ShowProduct(List<Product> products)
        {
            dataGridViewProducts.DataSource = products;
            dataGridViewProducts.Columns["Orders"].Visible = false;
        }

        public void ShowClient(List<Client> clients)
        {
            dataGridViewClients.DataSource = clients;
            dataGridViewClients.Columns["Orders"].Visible = false;
        }

        private void InvokeGet(Action action)
        {
            if (action != null) action();
        }

        private void InvokeDelete(Action action, DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count == 0 || dataGridView.SelectedCells.Count != 1 || dataGridView.SelectedCells[0].OwningColumn.Index != 0)
            {
                MessageBox.Show("Выберите номер!");
            }
            else if (action != null) action();
        }

        private void InvokeUpdate(Action action, DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count == 0 || dataGridView.SelectedCells.Count != 1 || dataGridView.SelectedCells[0].OwningColumn.Index != 0)
            {
                MessageBox.Show("Выберите номер!");
            }
            else if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Выберите данные для заказа!");
            }
            else if (action != null) action();
        }

        private void InvokeCreate(Action action, DataGridView dataGridView)
        {
            if (dataGridView.Name == "dataGridViewOrders")
            {
                if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
                {
                    MessageBox.Show("Выберите данные для заказа!");
                }
                else if (action != null) action();
            }
            else if (dataGridView.Name == "dataGridViewProducts")
            {
                if (textBox1.Text == "")
                { 
                    MessageBox.Show("Введите тип продукта!"); 
                }
                else if (action != null) action();
            }
            else if (dataGridView.Name == "dataGridViewClients")
            {
                if (textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Введите данные клиента!");
                }
                else if (action != null) action();
            }
        }
    }
}

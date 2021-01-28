using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    /// <summary>
    /// Класс связывающий форму и класс работы с данными
    /// </summary>
    class Presenter
    {


        MainFormInterface form;
        DataHandlerInterface dataHandler;
        public Presenter(MainFormInterface form, DataHandlerInterface dataHandler)
        {
            this.form = form;
            this.dataHandler = dataHandler;
            form.GetDataOrders += () => GetDataOrders();
            form.GetDataProduct += () => GetDataProduct();
            form.GetDataClients += () => GetDataClient();
            form.CreateOrder += () => CreateOrder();
            form.DeleteOrder += () => DeleteOrder();
            form.UpdateOrder += () => UpdateOrder();
            form.CreateProduct += () => CreateProduct();
            form.DeleteProduct += () => DeleteProduct();
            form.CreateClient += () => CreateClient();
            form.DeleteClient += () => DeleteClient();
            form.ChoiceClient += () => ChoiceClient();
            form.ChoiceProduct += () => ChoiceProduct();

            form.Show();
        }

        void GetDataOrders()
        {
            var orders = dataHandler.GetDataOrders();
            form.ShowOrders(orders);
        }
        void GetDataProduct()
        {
            var products = dataHandler.GetDataProducts();
            form.ShowProduct(products);
        }
        void GetDataClient()
        {
            var clients = dataHandler.GetDataClients();
            form.ShowClient(clients);
        }
        void CreateOrder()
        {
            dataHandler.CreateOrder(form.ClientIndex, form.ProductIndex, form.Date);
            this.GetDataOrders();
        }

        void DeleteOrder()
        {
            dataHandler.DeleteOrder(form.OrderIndex);
            this.GetDataOrders();
        }

        void UpdateOrder()
        {
            dataHandler.UpdateOrder(form.OrderIndex, form.ClientIndex, form.ProductIndex, form.Date);
            this.GetDataOrders();
            
        }

        void CreateProduct()
        {
            dataHandler.CreateProduct(form.ProductType, form.ProductCost, form.ProductInfo);
            this.GetDataProduct();
        }

        void DeleteProduct()
        {
            dataHandler.DeleteProduct(form.ProductIndexDel);
            this.GetDataProduct();
        }

        void CreateClient()
        {
            dataHandler.CreateClient(form.ClientName,form.ClientPhone);
            this.GetDataClient();
        }

        void DeleteClient()
        {
            dataHandler.DeleteClient(form.ClientIndexDel);
            this.GetDataClient();
        }

        void ChoiceClient()
        {
            form.AddClientsList(dataHandler.GetClientsList());
        }
        void ChoiceProduct()
        {
            form.AddProductsList(dataHandler.GetProductList());
        }
    }
}

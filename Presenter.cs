using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    class Presenter
    {


        MainFormInterface form;
        DataHandlerInterface dataHandler;
        public Presenter(MainFormInterface form, DataHandlerInterface dataHendler)
        {

            this.form = form;
            this.dataHandler = dataHendler;
            form.GetDataOrders += () => GetDataOrders();
            form.DeleteOrder += () => DeleteOrder();
            form.UpdateOrder += () => UpdateOrder();
            form.CreateOrder += () => CreateOrder();
            form.ChoiceClient += () => ChoiceClient();
            form.ChoiceProduct += () => ChoiceProduct();

            form.Show();

            


        }

        void GetDataOrders()
        {
            var orders = dataHandler.GetDataOrders();
            form.ShowOrders(orders);
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

        void CreateOrder()
        {
            dataHandler.CreateOrder(form.OrderIndex, form.ClientIndex, form.ProductIndex, form.Date);
            this.GetDataOrders();
        }

        void ChangeProduct()
        {

        }

        void ChangeClient()
        {

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

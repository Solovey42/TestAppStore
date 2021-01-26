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

        }

        void ChangeProduct()
        {

        }

        void ChangeClient()
        {

        }
    }
}

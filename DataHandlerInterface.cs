using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    interface DataHandlerInterface
    {

        List<ViewOrder> GetDataOrders();
        void DeleteOrder(int orderId);
        public void UpdateOrder(int orderId, int indexClient, int indexProduct, DateTime dateTime);

        public void CreateOrder(int orderId, int indexClient, int indexProduct, DateTime dateTime);

        List<string> GetClientsList();
        List<string> GetProductList();
    }
}

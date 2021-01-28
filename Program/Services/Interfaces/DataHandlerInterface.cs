using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    interface DataHandlerInterface
    {
        List<ViewOrder> GetDataOrders();
        List<Product> GetDataProducts();
        List<Client> GetDataClients();
        void CreateOrder(int indexClient, int indexProduct, DateTime dateTime);
        void DeleteOrder(int orderId);
        void UpdateOrder(int orderId, int indexClient, int indexProduct, DateTime dateTime);
        void CreateClient(string name, string phone);
        void DeleteClient(int clientId);
        void CreateProduct(string type, float cost, string info);
        void DeleteProduct(int productId);

        List<string> GetClientsList();
        List<string> GetProductList();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface MainFormInterface
    {
        void Show();

        event Action GetDataOrders;
        event Action GetDataProduct;
        event Action GetDataClients;
        event Action CreateOrder;
        event Action DeleteOrder;
        event Action UpdateOrder;
        event Action CreateProduct;
        event Action DeleteProduct;
        event Action CreateClient;
        event Action DeleteClient;
        event Action ChoiceClient;
        event Action ChoiceProduct;

        int OrderIndex { get; }
        int ClientIndex { get; }
        int ProductIndex { get; }
        DateTime Date { get; }
        int ProductIndexDel { get; }
        string ProductType { get; }
        float ProductCost { get; }
        string ProductInfo { get; }
        public int ClientIndexDel { get; }
        public string ClientName { get; }
        public string ClientPhone { get; }

        void ShowOrders(List<ViewOrder> orders);
        void ShowProduct(List<Product> products);
        void ShowClient(List<Client> clients);
        void AddClientsList(List<String> list);
        void AddProductsList(List<String> list);

    }
}


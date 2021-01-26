using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface MainFormInterface
    {
        void Show();

        event Action GetDataOrders;
        event Action DeleteOrder;
        event Action UpdateOrder;
        public event Action CreateOrder;
        public event Action ChoiceClient;
        public event Action ChoiceProduct;

        int OrderIndex { get; }
        public int ClientIndex { get; }
        public int ProductIndex { get; }
        public DateTime Date { get; }

        void ShowOrders(List<ViewOrder> orders);
        public void AddClientsList(List<String> list);
        public void AddProductsList(List<String> list);

    }
}


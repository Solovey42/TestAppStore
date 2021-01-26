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

        int OrderIndex { get; }

        void ShowOrders(List<ViewOrder> orders)
        {

        }
    }
}


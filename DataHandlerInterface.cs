using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    interface DataHandlerInterface
    {
        List<ViewOrder> GetDataOrders()
        {
            return new List<ViewOrder>();

        }
        void DeleteOrder(int id)
        {

        }
    }
}

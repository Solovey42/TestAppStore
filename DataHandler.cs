using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Store
{
    class DataHandler : DataHandlerInterface
    {
        List<Client> clients;
        List<Product> products;
        List<Order> orders;
      ///  List<Productlist> productlists;

        public DataHandler() 
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                clients = db.Clients.ToList();
                products = db.Products.ToList();
                orders = db.Orders.ToList();
              ///  productlists = db.Productlists.ToList();
            }
        }
            

        public List<ViewOrder> GetDataOrders()
        {
            List<ViewOrder> orders;
            using (StoreDBContext db = new StoreDBContext())
            {

                orders = db.ViewOrders.FromSqlRaw("SELECT Orders.ID, Name, Type, Cost, \"Date\" from Clients join Orders on " +
                                                                   "Clients.ID = Orders.ClientID join Products on " +
                                                                   "Products.ID = Orders.ProductID ").ToList();

            }

            return orders;
        }
        public void DeleteOrder(int id)
        {

            using (StoreDBContext db = new StoreDBContext())
            {
                db.Database.ExecuteSqlRaw($"DELETE FROM Orders WHERE id = {id}");
            }
        }
    }
}

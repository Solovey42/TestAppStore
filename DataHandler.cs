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

        public DataHandler() 
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                clients = db.Clients.ToList();
                products = db.Products.ToList();
                orders = db.Orders.ToList();
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
        public void DeleteOrder(int orderId)
        {

            using (StoreDBContext db = new StoreDBContext())
            {
                Order delOrder = (from order in db.Orders
                                  where order.Id == orderId
                                  select order).First();
                db.Orders.Remove(delOrder);
                db.SaveChanges();
            }
        }

        public void UpdateOrder(int orderId, int indexClient, int indexProduct, DateTime dateTime)
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                var newOrder = (from order in db.Orders
                             where order.Id == orderId
                         select order).First();
                newOrder.Clientid = clients[indexClient].Id;
                newOrder.Productid = products[indexProduct].Id;
                newOrder.Date = dateTime;
                db.Orders.Update(newOrder);
                db.SaveChanges();
            }
        }

        public void CreateOrder(int orderId, int indexClient, int indexProduct, DateTime dateTime)
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                Order newOrder = new Order { Clientid = clients[indexClient].Id, Productid = products[indexProduct].Id, Date = dateTime };
                db.Orders.Add(newOrder);
                db.SaveChanges();
            }
        }
        public List<string> GetClientsList()
        {
            List<string> clientsName = new List<string>();
            foreach (var client in clients)
            {
                clientsName.Add(client.Name);
            }
            return clientsName;
        }
        public List<string> GetProductList()
        {
            List<string> clientsType = new List<string>();
            foreach (var product in products)
            {
                clientsType.Add(product.Type);
            }
            return clientsType;
        }
    }
}

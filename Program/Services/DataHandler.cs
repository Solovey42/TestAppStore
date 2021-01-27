using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Store
{
    /// <summary>
    /// Класс работы с данными
    /// </summary>
    class DataHandler : DataHandlerInterface
    {
        List<Client> clients;
        List<Product> products;
        List<Order> orders;

/*        public DataHandler() 
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                clients = db.Clients.ToList();
                products = db.Products.ToList();
                orders = db.Orders.ToList();
            }
        }*/
            

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

        public List<ViewProduct> GetDataProducts()
        {
            List<ViewProduct> products;
            using (StoreDBContext db = new StoreDBContext())
            {
                products = db.ViewProducts.FromSqlRaw("SELECT ID, Type, Cost, Info from Products").ToList();
                return products;
            }
        }

        public List<ViewClient> GetDataClients()
        {
            List<ViewClient> clients;
            using (StoreDBContext db = new StoreDBContext())
            {
                clients = db.ViewClients.FromSqlRaw("SELECT ID, Name, Phone from Clients").ToList();
                return clients;
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

       
        public void CreateClient(string name, string phone)
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                Client newClient = new Client { Name = name, Phone = phone };
                db.Clients.Add(newClient);
                db.SaveChanges();
            }
        }

        public void DeleteClient(int clientId)
        {

            using (StoreDBContext db = new StoreDBContext())
            {
                Client delClient = (from client in db.Clients
                                  where client.Id == clientId
                                  select client).First();
                db.Clients.Remove(delClient);
                db.SaveChanges();
            }
        }
        public void CreateProduct(string type, float cost, string info)
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                Product newProduct = new Product { Type = type, Cost = cost, Info = info };
                db.Products.Add(newProduct);
                db.SaveChanges();
            }
        }

        public void DeleteProduct(int productId)
        {

            using (StoreDBContext db = new StoreDBContext())
            {
                Product delProduct = (from product in db.Products
                                    where product.Id == productId
                                    select product).First();
                db.Products.Remove(delProduct);
                db.SaveChanges();
            }
        }
        public List<string> GetClientsList()
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                List<Client> clients = db.Clients.ToList();
                List<string> clientsName = new List<string>();
            foreach (var client in clients)
                {
                    clientsName.Add(client.Name);
                }
                return clientsName;
            }
        }
        public List<string> GetProductList()
        {
            using (StoreDBContext db = new StoreDBContext())
            {
                List<Product> products = db.Products.ToList();
                List<string> productsType = new List<string>();
                foreach (var product in products)
                {
                    productsType.Add(product.Type);
                }
                return productsType;
            }
        }
    }
}

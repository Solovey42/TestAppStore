using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Store
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            

           

            /*          // создаем два объекта User
                        Client user1 = new Client { Name = "Tom", Phone = "1231241" };

                        // добавляем их в бд
                        db.Clients.AddRange(user1);
                        db.SaveChanges();*/



            // получаем объекты из бд

            using (StoreDBContext db = new StoreDBContext())
            {

              /*  List<ViewOrder> clients = db.ViewOrders.FromSqlRaw("SELECT Name, Type, Count, \"Date\", Orders.ID from Clients join Orders on " +
                                                                   "Clients.ID = Orders.ClientID join ProductLists on " +
                                                                   "Orders.ID = ProductLists.orderID join Products on " +
                                                                   "ProductLists.ProductID = Products.ID ").ToList();*/
             ///   clients = db.Clients.ToList();
             /*    foreach (ViewOrder client in clients)
                {

                }*/
                
            ///    products = db.Products.ToList();
            ///    orders = db.Orders.ToList();
            ///    productlists = db.Productlists.ToList();

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                

                Presenter bl = new Presenter(new Form(), new DataHandler());

            }
           


        }
    }
}

SELECT Name, Type, Cost, "Date" from Clients join Orders on
Clients.ID = Orders.ClientID join Products on 
Orders.ProductID = Products.ID
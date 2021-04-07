using System;

class Client 
{ 
    public string Name;
    public string Phone;
    public string Email;


    public Client(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }
}
enum PaymentMethod {Cash, Card, Site}
abstract class Delivery
{
    public string Address;
    public  Client Client;
    public DateTime Date;
    public string Description;
    public PaymentMethod PaymentMethod;
}

abstract class DeliveryProvider
{
    public string Name;
    public double Price;
}

class Courier:DeliveryProvider
{
    public string Phone;
}

class DeliveryCompany : DeliveryProvider
{
    public string Site;

}

enum Urgency {urgent, normal}

class HomeDelivery : Delivery
{
    public Urgency Urgency;
    public DeliveryProvider DeliveryProvider;
}

class PickPointDelivery : Delivery
{
    public DeliveryCompany DeliveryProvider;
    public string PickPointCode;
}

class ShopDelivery : Delivery
{
    
}

class Order<TDelivery,TStruct> where TDelivery : Delivery where TStruct:struct
{
    public string[] Products;
    public double TotalPrice;
    public TDelivery Delivery;
    public int Number;
    public string Description;
    public TStruct Struct;
    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

}
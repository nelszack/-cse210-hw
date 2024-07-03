using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1= new();
        Address address1=new("525 templeveiw dr","rexburg","Idaho","USA");
        Customer customer1= new();
        Product product1 =new("Apple","A101",1.05,5);
        Product product2 =new("Couch","C101",99.99,2);
        Product product3 =new("Bed","B101",70.86,2);
        customer1.SetName("bob smith");
        customer1.SetAddress(address1);
        order1.AddList(product1);
        order1.AddList(product2);
        order1.AddList(product3);
        order1.SetCostomer(customer1);
        
        Order order2= new();
        Address address2=new("1000 school dr","Idaho falls","Idaho","USA");
        Customer customer2= new();
        Product product4 =new("Apple","A101",5.05,5);
        Product product5 =new("Couch","C101",199.99,2);
        customer2.SetName("john smith");
        customer2.SetAddress(address2);
        order2.AddList(product4);
        order2.AddList(product5);
        order2.SetCostomer(customer2);
    
        order1.CreateLable();
        order2.CreateLable();
        

    }
}
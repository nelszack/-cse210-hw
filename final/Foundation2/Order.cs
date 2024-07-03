using System;

public class Order {
    private Customer _name;
    private List<Product> _order =new();


    public Order(){

    } 

    public void CreateLable() {
        double Shipping;
        Console.WriteLine(_name.GetName());
        Console.WriteLine(_name.GetAddress().MakeString());
        foreach (var item in _order)
        {
            Console.WriteLine($"{item.GetProductID()}: {item.GetProductName()} (${item.GetPrice()}) X {item.GetQuantity()} = ${item.TotalCost()}");
            
        }
        if (_name.GetAddress().GetNative()){
            Shipping=5;
        }
        else {
            Shipping=35;
        }
            Console.WriteLine($"Shipping cost: ${Shipping}");
            Console.WriteLine($"Total: ${CalculateTotal()+Shipping}");
    }
    public double CalculateTotal() {
        double total=0.00;
        foreach (var item in _order)
        {   
            double price= item.TotalCost();
            total+=price;
        }
       

        return total ;    
    }

    public void SetCostomer(Customer customer){
        _name=customer;
    }
    public void AddList(Product product) {
        _order.Add(product);
    }

}
using System;

public class Product {
    private string _name;
    private string _productId;
    private double _priceUnit;
    private int _quantity;

    public Product(string Name,string ProductId, double PriceUnit, int Quantity){
        _name=Name;
        _productId=ProductId;
        _priceUnit=PriceUnit;
        _quantity=Quantity;
    }
    public double TotalCost() {
        return _priceUnit*_quantity;
    }
    public string GetProductID() {
        return _productId;
    }
    public double GetPrice() {
        return _priceUnit;
    }
    public string GetProductName() {
        return _name;
    }
    public int GetQuantity() {
        return _quantity;
    }


}
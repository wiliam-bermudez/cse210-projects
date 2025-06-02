using System;
using System.Collections.Generic;


class Order
{
    private List<Product> _products;
    private Customer _customer;

    private double ShippingCostUSA = 5.00;
    private double ShippingCostInternational = 35.00;
 
     public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double TotalPrice()
    {
        double shipping_cost;
        double totalProductCost = 0;

        foreach (Product product in _products)
        {
            totalProductCost = +product.GetTotalPrice();
        }

        if (_customer.LiveInUSA()==true)
        {
            shipping_cost = ShippingCostUSA;
        }
        else
        {
            shipping_cost = ShippingCostInternational;
        }
        return totalProductCost + shipping_cost;
    }
    
     public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"Name: {product.GetName}, Product ID: {product.GetProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName}\n{_customer.GetAddress()}";
    }

}
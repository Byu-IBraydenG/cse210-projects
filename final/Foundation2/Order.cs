using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packinglabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packinglabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        }
        return packinglabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()} {_customer.GetAddress()}";
    }
}
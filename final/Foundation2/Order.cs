using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        if (customer.IsInUSA())
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
        foreach (Product product in products)
        {
            packinglabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        }
        return packinglabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {customer.GetName()} {customer.GetAddress()}";
    }
}
using System;
using System.Collections.Generic;
using System.Text;

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

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = customer.LivesInUSA() ? 5 : 35;
        total += shippingCost;

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Items in this package:");
        foreach (Product product in products)
        {
            sb.AppendLine($"- {product.Name} (ID: {product.ProductId})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Ship To:");
        sb.AppendLine(customer.Name);
        sb.AppendLine(customer.Address.GetFullAddress());
        return sb.ToString();
    }
}

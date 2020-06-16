using System;
using System.Text;
using Course.Entities.Enums;
using System.Collections.Generic;

namespace Course.Entities
{
  class Order
  {
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    public Client Client { get; set; }

    public Order(OrderStatus status, Client client)
    {
      Moment = DateTime.UtcNow;
      Status = status;
      Client = client;
    }

    public void AddItem(OrderItem item)
    {
      Items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
      Items.Remove(item);
    }

    public double Total()
    {
      double total = 0;
      foreach (OrderItem item in Items)
      {
        total += item.SubTotal();
      }
      return total;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Order moment: {Moment.ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss")}");
      sb.AppendLine($"Order status: {Status}");
      sb.AppendLine($"Client: {Client}");
      sb.AppendLine("Order items:");
      foreach (OrderItem item in Items)
      {
        sb.AppendLine(item.ToString());
      }
      return sb.ToString();
    }
  }
}
﻿using InventoryManagementApp.Common.Enums;

namespace InventoryManagementApp.Models;

public class Sale
{
    public int Id { get; set; }
    public DateTime? Date { get; set; }
    public int Amount { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }
    public PaymentArea? PaymentArea { get; set; }
    public Product? Product { get; set; }
    public Location? Location { get; set; }
}

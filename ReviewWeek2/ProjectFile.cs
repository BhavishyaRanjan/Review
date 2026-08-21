using System;
using System.Collections.Generic;

public class User {
    public string name { get; set; }
    public string email { get; set; }
    public long contact_No { get; set; }
    public ShippingAddress shippingAddress { get; set; }
    
    public void printUserInfo() {
        Console.WriteLine("Customer's details are as follows:");
        Console.WriteLine("Name :" + name);
        Console.WriteLine("email :" + email);
        Console.WriteLine("contact_no :" + contact_No);
    }
}

public class ShippingAddress {
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string pincode { get; set; }
    public string landmark { get; set; }
}

public class PassWordManagement : User {
    public string passEmail { get; set; }
    public string password { get; set; }
}

public class Product {
    public string name { get; set; }
    public int price { get; set; }
    public string brand { get; set; }
    public Retailer retailer { get; set; }
    public List<Ratings> ratings { get; set; } = new List<Ratings>();
}

public class Ratings {
    public string user_name { get; set; }
    public string feedback { get; set; }
    
    public void show_Reviews() {
        Console.WriteLine(user_name);
        Console.WriteLine(feedback);
    }
}

public class Cart {
    public List<Product> products { get; set; } = new List<Product>();
    
    public int GetTotalPrice() {
        int totalPrice = 0;
        for (int i = 0; i < products.Count; i++) {
            totalPrice += products[i].price;
        }
        return totalPrice;
    }
    
    public void CartDetails() {
        Console.WriteLine("Total Cart Price: " + GetTotalPrice());
    }
}

public class Retailer {
    public string name { get; set; }
    public string retailer_id { get; set; }
    public string address { get; set; }
    public Ratings rating { get; set; }
}

public class Logistics {
    public string wareHouseAddress { get; set; }
    public string deliveryPartner { get; set; }
    public string distance { get; set; }
    public string modeOfTransportation { get; set; }
    
    public void showLogisticsDetails() {
        Console.WriteLine(wareHouseAddress);
        Console.WriteLine(deliveryPartner);
        Console.WriteLine(distance);
        Console.WriteLine(modeOfTransportation);
    }
}

public class DeliveryPartner {
    public string name { get; set; }
    public string vehicleNumber { get; set; }
    public string journeyDate { get; set; }
    public string expectedDeliveryDate { get; set; }
    
    public void showDeliveryDetails() {
        Console.WriteLine(name);
        Console.WriteLine(vehicleNumber);
        Console.WriteLine(journeyDate);
        Console.WriteLine(expectedDeliveryDate);
    }
}

public abstract class Invoice {
    public string name { get; set; }
    public string dateOfPurchase { get; set; }
    public string modeOfPurchase { get; set; }
    public Discount discount { get; set; }
    public List<Product> bought { get; set; } = new List<Product>();
    
    public abstract void DisplayBill();
}

public class Bill : Invoice {
    public User user { get; set; }
    public Retailer retailer { get; set; }
    public ShippingAddress shipping { get; set; }
    
    public override void DisplayBill() {
        int totalPrice = 0;
        for (int i = 0; i < bought.Count; i++) {
            totalPrice += bought[i].price;
        }
        
        Console.WriteLine("User: " + (user?.name ?? "Unknown"));
        Console.WriteLine("Total Price: " + totalPrice);
    }
}

public class Discount {
    public Product product { get; set; }
    
    public void ApplyDiscount() {
        if (product != null) {
            if (product.price >= 999) {
                product.price = product.price - (product.price * 40) / 100;
            } else {
                product.price = product.price - (product.price * 10) / 100;
            }
        }
    }
}

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("E-Commerce System Initialized.");
    }
}
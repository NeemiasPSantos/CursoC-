﻿namespace ExEnum.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public OrderItem()
        {

        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}

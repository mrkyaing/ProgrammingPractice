using System;
namespace YCI
{
    public class Product
    {
        private string id, name, description, productCategory;
        private int quantity;
        private double price;
        private DateTime manufacturedDate;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Product Id");
                }
                id = value;
            }
        }//end of id
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Product Name");
                }
                name = value;
            }
        }//end of Name
        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Product Description");
                }
                description = value;
            }
        }//end of description
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid Product Quantity");
                }
                quantity = value;
            }
        }//end of quantity
        public string ProductCategory
        {
            get { return productCategory; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Product ProductCategory");
                }
                productCategory = value;
            }
        }//end of productCategory
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Product Price");
                }
                price = value;
            }
        }//end of price
        public DateTime ManufacturedDate
        {
            get { return manufacturedDate; }
            set
            {
                manufacturedDate = value;
            }
        }

        private double GetTaxAmountOnTotal()
        {
            double taxAmount = 0;
            double totalAmount = price * quantity;
            if(totalAmount >= 50000)
            {
                taxAmount = totalAmount * 0.05;
            }
            return taxAmount;
        }
    }
}

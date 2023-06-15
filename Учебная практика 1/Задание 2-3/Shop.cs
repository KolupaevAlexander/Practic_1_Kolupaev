using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    class Shop
    {
        private Dictionary<Product, int> products;
        private decimal money=0;
        public decimal Money { get { return money; } set { money = value; } }
        public Dictionary<Product, int> Producs { get { return products; }}
        public Shop ()
        {
            products = new Dictionary<Product, int>();
        }
        public void AddProduct (Product product, int count)
        {
            products.Add(product, count);
        }
        public void WriteAllProducts ()
        {
            Console.WriteLine("Список продуктов: ");
            foreach (var product in products)
            {
                Console.WriteLine(product.Key.GetInfo() + "; Количество: " + product.Value);
            }
        }
        public void CreateProduct (string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        public void Sell (Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] < count)
                {
                    MessageBox.Show("Нет в наличии!");
                } else
                {
                    products[product]-=count;
                    money += product.Price*count;
                }
            } else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        public void Sell (string ProductName, int count)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell, count);
            } else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        public Product FindByName (string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
    }
}

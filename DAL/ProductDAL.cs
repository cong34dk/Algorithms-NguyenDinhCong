using Algorithms_NguyenDinhCong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_NguyenDinhCong.DAL
{
    public class ProductDAL
    {
        private List<Product> _products = new List<Product>
        {
            new Product("CPU", 750, 10, 1),
            new Product("RAM", 50, 2, 2),
            new Product("HDD", 70, 1, 2),
            new Product("Main", 400, 3, 1),
            new Product("Keyboard", 30, 8, 4),
            new Product("Mouse", 25, 50, 4),
            new Product("VGA", 60, 35, 3),
            new Product("Monitor", 120, 28, 2),
            new Product("Case", 120, 28, 5)
        };

        //Phuong thuc lay tat ca san pham
        public List<Product> GetProducts()
        {
            return _products;
        }
    }

}

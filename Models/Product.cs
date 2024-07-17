using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_NguyenDinhCong.Models
{
    public class Product
    {
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public int Quality { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } // Thuộc tính mới để lưu tên danh mục

        public Product(string name, decimal price, int quality, int categoryId)
        {
            Name = name;
            Price = price;
            Quality = quality;
            CategoryId = categoryId;
        }
    }
}

using Algorithms_NguyenDinhCong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_NguyenDinhCong.DAL
{
    public class CategoryDAL
    {
        private List<Category> _categories = new List<Category>
        {
            new Category(1, "computer"),
            new Category(2, "Memory"),
            new Category(3, "Card"),
            new Category(4, "Accessory")
        };

        //Phuong thuc lay tat ca danh muc
        public List<Category> GetCategories()
        {
            return _categories;
        }

    }
}

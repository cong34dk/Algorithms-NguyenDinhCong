using Algorithms_NguyenDinhCong.BLL;
using Algorithms_NguyenDinhCong.DAL;
using Algorithms_NguyenDinhCong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_NguyenDinhCong.GUI
{
    public class SortAlgorithmGUI
    {
        private ProductDAL productDAL = new ProductDAL(); // Khai báo và khởi tạo DAL để lấy danh sách sản phẩm
        private CategoryDAL categoryDAL = new CategoryDAL();

        //Bài 11 Thuật toán Bubble Sort sắp xếp sản phẩm theo giá từ thấp đến cao
        public void SortByPriceGUI()
        {
            //Lay danh sach san pham
            List<Product> products = productDAL.GetProducts();

            List<Product> result = SortAlgorithmBLL.SortByPrice(products);

            foreach (Product item in result)
            {
                Console.WriteLine($"Product sort: {item.Name}, Price: {item.Price}, Quality: {item.Quality}");

            }
        }

        //Bai 12thuật toán Insertion Sort để sắp xếp danh sách các sản phẩm theo độ dài của tên từ cao đến thấp.
        public void SortByNameGUI()
        {
            //Lay danh sach san pham
            List<Product> products = productDAL.GetProducts();

            List<Product> result = SortAlgorithmBLL.SortByName(products);

            foreach (Product item in result)
            {
                Console.WriteLine($"Product sort: {item.Name}, Price: {item.Price}, Quality: {item.Quality}");

            }

        }
        //Bai 13thuật toán Insertion Sort để sắp xếp danh sách các sản phẩm theo tên danh mục (category name) theo thứ tự ABC,
        public void SortByCategoryNameGUI()
        {
            List<Product> products = productDAL.GetProducts(); // Lấy danh sách sản phẩm từ DAL
            List<Category> categories = categoryDAL.GetCategories(); // Lấy danh sách danh mục từ DAL

            // Sử dụng phương thức từ BLL để sắp xếp sản phẩm theo tên danh mục
            List<Product> result = SortAlgorithmBLL.SortByCategoryName(products, categories);

            foreach (Product item in result)
            {
                string categoryName = categories.Find(c => c.Id == item.CategoryId)?.Name;
                Console.WriteLine($"Product sort: {item.Name}, Price: {item.Price}, Quality: {item.Quality}, Category: {categoryName}");

            }

        }

        //Bai14 tra về danh sách các sản phẩm chứa tên danh mục tương ứng theo categoryId.
        public void MapProductsByCategoryGUI()
        {
            List<Product> products = productDAL.GetProducts(); // Lấy danh sách sản phẩm từ DAL
            List<Category> categories = categoryDAL.GetCategories(); // Lấy danh sách danh mục từ DAL

            // Sử dụng phương thức từ BLL để gán tên danh mục cho sản phẩm
            List<Product> result = SortAlgorithmBLL.MapProductByCategory(products, categories);

            Console.WriteLine("\nDanh sach san pham kem ten danh muc:");

            foreach (Product product in result)
            {
                Console.WriteLine($"Product: {product.Name}, Category: {product.CategoryName}, Price: {product.Price}, Quality: {product.Quality}");
            }
        }

        //Bai 15 Tim san pham co giá nhỏ nhất
        public void MinByPriceGUI()
        {
            List<Product> products = productDAL.GetProducts(); // Lấy danh sách sản phẩm từ DAL

            //Su dung phuong thuc BLL
            Product result = SortAlgorithmBLL.MinByPrice(products);

            Console.WriteLine("\nSan pham co gia thap nhat la:");

            Console.WriteLine($"Product: {result.Name}, Category: {result.CategoryName}, Price: {result.Price}, Quality: {result.Quality}");

        }

        //Bai 16 Tim san pham co giá lớn nhất
        public void MaxByPriceGUI()
        {
            List<Product> products = productDAL.GetProducts(); // Lấy danh sách sản phẩm từ DAL

            //Su dung phuong thuc BLL
            Product result = SortAlgorithmBLL.MaxByPrice(products);

            Console.WriteLine("\nSan pham co gia cao nhat la:");

            Console.WriteLine($"Product: {result.Name}, Category: {result.CategoryName}, Price: {result.Price}, Quality: {result.Quality}");

        }
    }
}

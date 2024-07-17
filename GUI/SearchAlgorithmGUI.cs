using Algorithms_NguyenDinhCong.BLL;
using Algorithms_NguyenDinhCong.DAL;
using Algorithms_NguyenDinhCong.Models;
using System;
using System.Collections.Generic;

namespace Algorithms_NguyenDinhCong.GUI
{
    public class SearchAlgorithmGUI
    {
        private ProductDAL productDAL = new ProductDAL(); // Khai báo và khởi tạo DAL để lấy danh sách sản phẩm


        //Bai4 Hàm tìm sản phẩm theo tên gần đúng trả về 1 list tìm kiếm được
        public void SearchAndDisplayProduct()
        {
            List<Product> products = productDAL.GetProducts(); // Lấy danh sách sản phẩm từ DAL

            // Sử dụng phương thức từ BLL để tìm sản phẩm
            List<Product> foundProducts = SearchAlgorithmBLL.FindProduct(products, "Mo");

            //In 
            Console.WriteLine("\nBai 4");

            if (foundProducts.Count > 0)
            {
                foreach (Product foundProduct in foundProducts)
                {
                    Console.WriteLine($"Product found: {foundProduct.Name}, Price: {foundProduct.Price}, Quality: {foundProduct.Quality}");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        //Bài 5 Hàm tìm sản phẩm theo danh mục
        public void SearchProductByCategory()
        {
            int categoryId = 1;
            List<Product> products = productDAL.GetProducts(); // Lấy danh sách sản phẩm từ DAL
            List<Product> foundProducts = SearchAlgorithmBLL.FindProductByCategory(products, categoryId);

            //In 
            Console.WriteLine("\nBai 5");

            if (foundProducts.Count > 0)
            {
                foreach (Product foundProduct in foundProducts)
                {
                    Console.WriteLine($"Product found in category {categoryId}: {foundProduct.Name}, Price: {foundProduct.Price}, Quality: {foundProduct.Quality}");
                }
            }
            else
            {
                Console.WriteLine($"No products found in category {categoryId}");
            }

        }

        //Bài 6 Hàm lọc sản phẩm theo giá cả
        public void SearchProductByPrice()
        {
            List<Product> products = productDAL.GetProducts();

            List<Product> foundProducts = SearchAlgorithmBLL.FindProductByPrice(products, 50);

            Console.WriteLine("\nBai 6");

            if(foundProducts.Count > 0)
            {
                foreach (var item in foundProducts)
                {
                    Console.WriteLine($"Product found: Name: {item.Name}, Price: {item.Price}, Quality: {item.Quality}");
                }
            }
            else
            {
                Console.WriteLine("No found product");
            }
        }
    }
}

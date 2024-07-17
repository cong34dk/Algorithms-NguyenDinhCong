using Algorithms_NguyenDinhCong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_NguyenDinhCong.BLL
{
    public class SortAlgorithmBLL
    {
        //Bài 11 Thuật toán Bubble Sort sắp xếp sản phẩm theo giá từ thấp đến cao
        public static List<Product> SortByPrice(List<Product> listProducts)
        {
            int n = listProducts.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listProducts[j].Price > listProducts[j + 1].Price)
                    {
                        //Hoan vi
                        Product temp = listProducts[j];
                        listProducts[j] = listProducts[j + 1];
                        listProducts[j + 1] = temp;
                    }
                }
            }
            return listProducts;
        }

        //Bai 12thuật toán Insertion Sort để sắp xếp danh sách các sản phẩm theo độ dài của tên từ cao đến thấp.
        public static List<Product> SortByName(List<Product> listProducts)
        {
            int n = listProducts.Count;
            for (int i = 1; i < n; i++)
            {
                Product key = listProducts[i];
                int j = i - 1;

                // Di chuyển các phần tử có độ dài tên nhỏ hơn key về phía sau
                while (j >= 0 && listProducts[j].Name.Length < key.Name.Length)
                {
                    listProducts[j + 1] = listProducts[j];
                    j = j - 1;
                }
                listProducts[j + 1] = key;
            }
            return listProducts;
        }

        //Bai 13thuật toán Insertion Sort để sắp xếp danh sách các sản phẩm theo tên danh mục (category name) theo thứ tự ABC,
        public static List<Product> SortByCategoryName(List<Product> listProducts, List<Category> listCategories)
        {
            int n = listProducts.Count;
            for (int i = 1; i < n; i++)
            {
                Product key = listProducts[i];
                int j = i - 1;

                // Lấy tên danh mục của sản phẩm key
                string keyCategoryName = listCategories.Find(c => c.Id == key.CategoryId)?.Name;

                // Di chuyển các phần tử có tên danh mục lớn hơn keyCategoryName về phía sau
                while (j >= 0 && string.Compare(listCategories.Find(c => c.Id == listProducts[j].CategoryId)?.Name, keyCategoryName) > 0)
                {
                    listProducts[j + 1] = listProducts[j];
                    j = j - 1;
                }
                listProducts[j + 1] = key;
            }
            return listProducts;
        }

        //Bai14 tra về danh sách các sản phẩm chứa tên danh mục tương ứng theo categoryId.
        public static List<Product> MapProductByCategory(List<Product> listProducts, List<Category> listCategories)
        {
            foreach (var product in listProducts)
            {
                var category = listCategories.Find(c => c.Id == product.CategoryId);
                if (category != null)
                {
                    product.CategoryName = category.Name; // Gán tên danh mục cho sản phẩm
                }
            }
            return listProducts;
        }

        //Bai 15 Tim san pham co giá nhỏ nhất
        public static Product MinByPrice(List<Product> listProducts)
        {
            if (listProducts == null || listProducts.Count == 0)
            {
                return null;
            }

            Product minProduct = listProducts[0];

            for (int i = 1; i < listProducts.Count; i++)
            {
                if (listProducts[i].Price < minProduct.Price)
                {
                    minProduct = listProducts[i];
                }
            }

            return minProduct;
        }

        //Bai 16 Tim san pham co giá lớn nhất
        public static Product MaxByPrice(List<Product> listProducts)
        {
            if (listProducts == null || listProducts.Count == 0)
            {
                return null;
            }

            Product maxProduct = listProducts[0];

            for (int i = 1; i < listProducts.Count; i++)
            {
                if (listProducts[i].Price > maxProduct.Price)
                {
                    maxProduct = listProducts[i];
                }
            }

            return maxProduct;
        }
    }
}

using Algorithms_NguyenDinhCong.DAL;
using Algorithms_NguyenDinhCong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_NguyenDinhCong.BLL
{
    public class SearchAlgorithmBLL
    {

        //Bai4 Hàm tìm sản phẩm theo tên gần đúng trả về 1 list tìm kiếm được
        public static List<Product> FindProduct(List<Product> listProducts, string nameProduct)
        {
            //Khởi tạo List chứa danh sách sản phẩm tìm kiếm được
            List<Product> result = new List<Product>();

            foreach (Product product in listProducts)
            {
                //Check giá trị cần tìm kiếm có trong data hay k và ko phân biệt chữ hoa thường
                if (product.Name.Contains(nameProduct, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product);
                }
            }
            return result;
        }

        //Bài 5 Hàm tìm sản phẩm theo danh mục
        public static List<Product> FindProductByCategory(List<Product> listProducts, int categoryId)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in listProducts)
            {
                //Nếu CategoryId của sản phẩm bằng categoryId truyền vào, sản phẩm đó được thêm vào danh sách result.
                if (product.CategoryId == categoryId)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        //Bài 6 Lọc sản phầm theo giá cả
        public static List<Product> FindProductByPrice(List<Product> listProducts, int price)
        {
            List<Product> result = new List<Product> ();
            foreach (Product product in listProducts)
            {
                //Nếu Giá sản phẩm trong data nhỏ hơn hoặc bằng giá truyền vào, sản phẩm thêm vào result
                if (product.Price <= price)
                {
                    result.Add(product);
                }
            }

            return result;
        }
    }
}

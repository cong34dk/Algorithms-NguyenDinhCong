using Algorithms_NguyenDinhCong.BLL;
using Algorithms_NguyenDinhCong.GUI;
using Algorithms_NguyenDinhCong.Models;
using System;

public class Program : SearchAlgorithmBLL
{
    public static void Main()
    {
        SearchAlgorithmGUI searchAlgorithmGUI = new SearchAlgorithmGUI();
        //Bai4 Hàm tìm sản phẩm
        searchAlgorithmGUI.SearchAndDisplayProduct();

        //Bai5 Hàm tìm sản phẩm theo danh mục
        searchAlgorithmGUI.SearchProductByCategory();

        //Bai6 Hàm tìm sản phẩm theo giá
        searchAlgorithmGUI.SearchProductByPrice();
        Console.ReadKey();
    }
}
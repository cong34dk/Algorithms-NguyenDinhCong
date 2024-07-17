using Algorithms_NguyenDinhCong.BLL;
using Algorithms_NguyenDinhCong.GUI;
using Algorithms_NguyenDinhCong.Models;
using System;

public class Program : SearchAlgorithmBLL
{
    public static void Main()
    {
        SearchAlgorithmGUI searchAlgorithmGUI = new SearchAlgorithmGUI();
        SortAlgorithmGUI sortAlgorithmGUI = new SortAlgorithmGUI();
        //Bai4 Hàm tìm sản phẩm
        Console.WriteLine("\nBai4");
        searchAlgorithmGUI.SearchAndDisplayProduct();

        //Bai5 Hàm tìm sản phẩm theo danh mục
        Console.WriteLine("\nBai5");
        searchAlgorithmGUI.SearchProductByCategory();

        //Bai6 Hàm tìm sản phẩm theo giá
        Console.WriteLine("\nBai6");
        searchAlgorithmGUI.SearchProductByPrice();

        //Bài 11 Thuật toán Bubble Sort sắp xếp sản phẩm theo giá từ thấp đến cao
        Console.WriteLine("\nBai11");
        sortAlgorithmGUI.SortByPriceGUI();

        //Bai 12thuật toán Insertion Sort để sắp xếp danh sách các sản phẩm theo độ dài của tên từ cao đến thấp.
        Console.WriteLine("\nBai12");
        sortAlgorithmGUI.SortByNameGUI();

        //Bai 13thuật toán Insertion Sort để sắp xếp danh sách các sản phẩm theo tên danh mục (category name) theo thứ tự ABC,
        Console.WriteLine("\nBai13");
        sortAlgorithmGUI.SortByCategoryNameGUI();

        //Bai14 tra về danh sách các sản phẩm chứa tên danh mục tương ứng theo categoryId.
        Console.WriteLine("\nBai14");
        sortAlgorithmGUI.MapProductsByCategoryGUI();

        //Bai 15 Tim san pham co giá nhỏ nhất
        Console.WriteLine("\nBai15");
        sortAlgorithmGUI.MinByPriceGUI();

        //Bai 16 Tim san pham co giá lớn nhất
        Console.WriteLine("\nBai16");
        sortAlgorithmGUI.MaxByPriceGUI();
        Console.ReadKey();
    }
}
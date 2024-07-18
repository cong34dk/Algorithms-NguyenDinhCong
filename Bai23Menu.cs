using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Recursive
{
    public class Bai23Menu
    {
        public class Menu
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int ParentId { get; set; }

            public Menu(int id, string title, int parentId)
            {
                Id = id;
                Title = title;
                ParentId = parentId;
            }
        }

        //phương thức để in ra Menu
        public static void PrintMenu(List<Menu> menus)
        {
            // Lấy các menu cấp gốc (có ParentId = 0)
            var rootMenus = GetRootMenus(menus);

            //In từng menu cấp gốc
            foreach (var rootMenu in rootMenus)
            {
                Console.WriteLine(rootMenu.Title); // In tiêu đề của menu cấp gốc
                PrintSubMenu(menus, rootMenu.Id, 1); // In các menu con của menu cấp gốc
            }
        }

        //Phương thức lấy danh sách các menu cấp gốc
        public static List<Menu> GetRootMenus(List<Menu> menus)
        {
            return menus.FindAll(m => m.ParentId == 0); // Trả về danh sách các menu có ParentId = 0
        }

        // Phương thức để in ra các menu con của một menu
        public static void PrintSubMenu(List<Menu> menus, int parentId, int indentLevel)
        {
            // Lấy danh sách các menu con của parentId
            var subMenus = menus.FindAll(m => m.ParentId == parentId);

            // In từng menu con
            foreach (var subMenu in subMenus)
            {
                // Sử dụng dấu "-" để thụt vào theo mức độ indentLevel
                Console.WriteLine(new string('-', indentLevel * 2) + " " + subMenu.Title);

                // Đệ quy để in các menu con của menu con
                PrintSubMenu(menus, subMenu.Id, indentLevel + 1);
            }
        }
    }
}

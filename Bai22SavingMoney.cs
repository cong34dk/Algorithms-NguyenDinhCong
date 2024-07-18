using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Recursive
{
    public class Bai22SavingMoney
    {
        public static int CalMonthHelper(double money, double rate, double target, int months)
        {
            if (money >= target)
            {
                return months;
            }
            else
            {
                return CalMonthHelper(money + money * (rate / 100), rate, target, months + 1);
            }
        }

        // Hàm tính số tháng dùng đệ quy
        public static int CalCalculateMonthsRecursive(double money, double rate)
        {
            double target = money * 2;
            return CalMonthHelper(money, rate, target, 0);
        }

        //Ham tinh so thang ko dung de quy
        public static int CalculateMonthsLoop(double money, double rate)
        {
            int months = 0;
            double target = money * 2;

            while (money < target)
            {
                money += money * (rate / 100);
                months++;
            }

            return months;
        }
    }
}
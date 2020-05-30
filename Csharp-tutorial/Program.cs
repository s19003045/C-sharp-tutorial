using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Csharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            // My first program
            Console.WriteLine("Hello world");
            Console.Write("Good job");
            Console.WriteLine("I am here");
     
            #endregion


            // ======DataType: 數值======
            int a = 8;
            int b = 9;
            int c = a + b;
            Console.WriteLine(c);

            double d = 2.0;
            Console.WriteLine("d  :" + d);  // d:  2
            d = 4.0;
            // 錯誤寫法
            Console.WriteLine("d: ", d);  // d

            double e = 4.0;
            Console.WriteLine(e);   // 4

            decimal f = 1 / 4;
            Console.WriteLine(f);   // 0

            // =======轉換型別======
            int h = (int)1.0;
            Console.WriteLine(h);  // 1

            string a1 = "1234";
            int b1 = Convert.ToInt32(a1);//把a這個字串轉成int
            Console.WriteLine(a1);  // 1234
            Console.WriteLine(b1);  // 1234

            a1 = "1234";
            b1 = int.Parse(a1);
            Console.WriteLine(b1);  // 1234


            string c1 = "2019/09/05";
            DateTime d1 = Convert.ToDateTime(c1);//把c這個字串轉成時間物件
            Console.WriteLine(c1);  // 2019 / 09 / 05
            Console.WriteLine(d1);  // 2019 / 9 / 5 上午 12:00:00
        

            d1 = new DateTime();
            string e1 = d1.ToString();
            Console.WriteLine(e1);   // 0001/1/1 上午 12:00:00
            d1 = new DateTime(2020,6,1);
            e1 = d1.ToString();
            Console.WriteLine(e1);  // 2020/6/1 上午 12:00:00

            // =======DataType: string======
            string msg = "Today is not my day.";
            Console.WriteLine(msg);

            string url = "https://ithelp.ithome.com.tw/articles/10213867";
            Console.WriteLine(url);  //  https://ithelp.ithome.com.tw/articles/10213867

            url = @"https://ithelp.ithome.com.tw/articles/10213867";
            Console.WriteLine(url);  //  https://ithelp.ithome.com.tw/articles/10213867

            msg = "It's a good day.";
            Console.WriteLine(msg);  // It's a good day.

            msg = "It\'s a good day.";
            Console.WriteLine(msg);  // It's a good day.
            Console.WriteLine(msg.Length);   // 16

            // operator
            int d2 = 0;
            Console.WriteLine(d2);//先輸出d2,此時d2是0
            Console.WriteLine(d2++);//輸出d2,此時d2是0，然後把d2+1，0+1=1
            Console.WriteLine(d2);//因為上面那行，d2變成1了
            Console.WriteLine("=======================================");

            int e2 = 0;
            Console.WriteLine(e2);//先輸出e2,此時e2是0
            Console.WriteLine(++e2);//把e2+1後輸出，0+1=1
            Console.WriteLine(e2);//e2是1
            Console.WriteLine("=======================================");

            //如果加上算術運算子也是一樣喔
            int f2 = 7;
            Console.WriteLine(f2);//先輸出7,此時f2是7
            Console.WriteLine(++f2 / 2);//先執行7+1=8，然後8/2=4,輸出4
            Console.WriteLine(f2);//f2是8，輸出8
            Console.WriteLine("=======================================");

            int g2 = 6;
            Console.WriteLine(g2);//先輸出6,此時g2是6
            Console.WriteLine(g2++ / 2);//先執行6/2=3，輸出3，再執行6+1=7
            Console.WriteLine(g2);//g2是6+1=7，輸出7

            // Bitwise operator(二位元運算子)
            Console.WriteLine(3 >> 1);  // 1
            // 說明：0011  (3)=>  右移 1 格  => 0001  (1)

            Console.WriteLine(3 << 1);  // 6
            // 說明：0011  (3)=>  左移 1 格  => 0110  (6)

            Console.WriteLine(3 | 1);  // 3
            // 說明：0011 (3) |  0001 (1)   =>  0011 (3)

            Console.WriteLine(3 & 1);  // 1
            // 說明：0011 (3) |  0001 (1)   =>  0001 (1)

            // 互斥
            Console.WriteLine(3 ^ 1);  // 2
            // 說明：0011 (3) ^  0001 (1)   =>  0010 (2)


            // 二進位制後完全相反
            Console.WriteLine(~3);  // -4
            // 說明：0011 (3)   =>  1100 (4)
            // 1100 最前面的 1 代表 負數

            a = 3;
            a &= 1;  // 相當於 a = a & 1
            Console.WriteLine(a);  // 1
            // 說明： 0011 (3)  &  0001 (1)  => 0001

            b = 3;
            b |= 2;  // 相當於 b = b | 2
            Console.WriteLine(b);  // 3
            // 說明： 0011 (3)  &  0010 (2)  => 0011 (3)

            c = 3;
            c ^= 2;  // 相當於 c = c ^ 2
            Console.WriteLine(c);  // 1
            // 說明： 0011 (3)  ^  0010 (2)  => 0001 (1)


            Console.ReadLine();


        }
    }
}

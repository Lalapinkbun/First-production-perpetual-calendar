using System;

namespace lala
{
    class thetime
    {
        public int plInYear;
        public int plInMonth;
        public int nd;
        public void inYear(int inYear) { //这里输入年份
            plInYear = inYear;
        }
        
        public void inMonth(int inMonth) { //这里输入月份
            plInMonth = inMonth;
        }
        public int readYear() { //这里读取年份
            return plInYear;
        }
        public int readMonth() { //这里读取月份
            return plInMonth;
        }

        public int returnTotalOfDay() { //这里导出总数
            if ( plInMonth == 1)
                return 31;
            else if ( plInMonth == 2){
                if ( (plInYear % 4) != 0)
                    return 28;
                else{
                    if ( (plInYear % 100) != 0)
                        return 29;
                    else{
                        if ( (plInYear % 400) == 0)
                            return 29;
                        else
                            return 28;
                    }
                }
            }
            else if ( plInMonth == 3)
                return 31;
            else if ( plInMonth == 4)
                return 30;
            else if ( plInMonth == 5)
                return 31;
            else if ( plInMonth == 6)
                return 30;
            else if ( plInMonth == 7)
                return 31;
            else if ( plInMonth == 8)
                return 31;
            else if ( plInMonth == 9)
                return 30;
            else if ( plInMonth == 10)
                return 31;
            else if ( plInMonth == 11)
                return 30;
            else if ( plInMonth == 12)
                return 31;
            else
                return -1;
        }
        
        public int returnDay(){
        //C：2(3-(c mod4))（格里历）
        //Y：(y mod28+[y mod28/4])mod7（闰年1、2月份Y-1）或查年份星期表
        //M：((3.4+(m-3)mod12×2.6)mod7（1、2月份M-1）或查月份星期表
        //D：d mod7、或查日期星期表
        //就是说——W=(C+Y+M+D)mod7

            int c = plInYear / 100;
            int y = plInYear % 100;
            int m = plInMonth;
            int d = 1;

            int C = 2 * (3-(c % 4));
            int Y = ((y % 28) + ((y % 28) / 4)) % 7;
            int M = ((int)(3.4 + (m - 3) % 12 * 2.6) % 7);
            int D = d % 7;

            //Console.WriteLine("C=" + C + ",Y=" + Y + ",M=" + M + ",D=" + D + "\n");

            //int nd = (C + Y + M + D) % 7;
            return (C + Y + M + D) % 7;

            //int a = (((plInYear-1)-((plInYear-1)%400))/400)*97;
            //int b = ((((plInYear-1)%400)-(((plInYear-1)%400)%100))/100)*24;
            //int c = ((((plInYear-1)%400)%100)-((((plInYear-1)%400)%100)%4))/4;
            //int temp = a + b +c ; int day=((plInYear-1)*365)+1+temp; int dates = day %7;

            //Console.WriteLine("date: " + dates);

            //return 0;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lala";

            thetime time = new thetime();
            Console.WriteLine("Input year: ");
            time.inYear(Convert.ToInt32 (Console.ReadLine()));
            Console.WriteLine("Input Month: ");
            time.inMonth(Convert.ToInt32 (Console.ReadLine()));
            //Console.Write("The Year Will Be " + time.readYear() + "\n");
            //Console.Write("The Month Will Be " + time.readMonth() + "\n");

            //int ret = time.returnTotalOfDay();
            //if (ret > 0)
            //    Console.WriteLine(ret);
            //else
            //    Console.WriteLine("Invalid Month \n");

            Console.WriteLine("the first month of day is: " + time.returnDay());

            int nd = time.returnDay();
            int nry = time.returnTotalOfDay();
            int nm = time.readMonth();

            if (nry == 29 && nm == 2){
                if (nd == 1){
                    //Console.WriteLine("Monday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("1  2  3  4  5  6  7 ");
                    Console.WriteLine("8  9  10 11 12 13 14");
                    Console.WriteLine("15 16 17 18 19 20 21");
                    Console.WriteLine("22 23 24 25 26 27 28");
                    Console.WriteLine("29                  ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 2){
                    //Console.WriteLine("Tuesday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("   1  2  3  4  5  6 ");
                    Console.WriteLine("7  8  9  10 11 12 13");
                    Console.WriteLine("14 15 16 17 18 19 20");
                    Console.WriteLine("21 22 23 24 25 26 27");
                    Console.WriteLine("28 29               ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 3){
                    //Console.WriteLine("Wednesday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("      1  2  3  4  5 ");
                    Console.WriteLine("6  7  8  9  10 11 12");
                    Console.WriteLine("13 14 15 16 17 18 19");
                    Console.WriteLine("20 21 22 23 24 25 26");
                    Console.WriteLine("27 28 29            ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 4){
                    //Console.WriteLine("Thursday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("         1  2  3  4 ");
                    Console.WriteLine("5  6  7  8  9  10 11");
                    Console.WriteLine("12 13 14 15 16 17 18");
                    Console.WriteLine("19 20 21 22 23 24 25");
                    Console.WriteLine("26 27 28 29         ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 5){
                    //Console.WriteLine("Friday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("            1  2  3 ");
                    Console.WriteLine("4  5  6  7  8  9  10");
                    Console.WriteLine("11 12 13 14 15 16 17");
                    Console.WriteLine("18 19 20 21 22 23 24");
                    Console.WriteLine("25 26 27 28 29      ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 6){
                    //Console.WriteLine("Saturday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("               1  2 ");
                    Console.WriteLine("3  4  5  6  7  8  9 ");
                    Console.WriteLine("10 11 12 13 14 15 16");
                    Console.WriteLine("17 18 19 20 21 22 23");
                    Console.WriteLine("24 25 26 27 28 29   ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 7){
                    //Console.WriteLine("Sunday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("                  1 ");
                    Console.WriteLine("2  3  4  5  6  7  8 ");
                    Console.WriteLine("9  10 11 12 13 14 15");
                    Console.WriteLine("16 17 18 19 20 21 22");
                    Console.WriteLine("23 24 25 26 27 28 29");
                    Console.WriteLine("                    ");
                }
                else
                    Console.WriteLine("What?");
            }
            else if (nry == 28 && nm == 2){
                if (nd == 1){
                    //Console.WriteLine("Monday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("1  2  3  4  5  6  7 ");
                    Console.WriteLine("8  9  10 11 12 13 14");
                    Console.WriteLine("15 16 17 18 19 20 21");
                    Console.WriteLine("22 23 24 25 26 27 28");
                    Console.WriteLine("                    ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 2){
                    //Console.WriteLine("Tuesday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("   1  2  3  4  5  6 ");
                    Console.WriteLine("7  8  9  10 11 12 13");
                    Console.WriteLine("14 15 16 17 18 19 20");
                    Console.WriteLine("21 22 23 24 25 26 27");
                    Console.WriteLine("28                  ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 3){
                    //Console.WriteLine("Wednesday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("      1  2  3  4  5 ");
                    Console.WriteLine("6  7  8  9  10 11 12");
                    Console.WriteLine("13 14 15 16 17 18 19");
                    Console.WriteLine("20 21 22 23 24 25 26");
                    Console.WriteLine("27 28               ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 4){
                    //Console.WriteLine("Thursday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("         1  2  3  4 ");
                    Console.WriteLine("5  6  7  8  9  10 11");
                    Console.WriteLine("12 13 14 15 16 17 18");
                    Console.WriteLine("19 20 21 22 23 24 25");
                    Console.WriteLine("26 27 28            ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 5){
                    //Console.WriteLine("Friday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("            1  2  3 ");
                    Console.WriteLine("4  5  6  7  8  9  10");
                    Console.WriteLine("11 12 13 14 15 16 17");
                    Console.WriteLine("18 19 20 21 22 23 24");
                    Console.WriteLine("25 26 27 28         ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 6){
                    //Console.WriteLine("Saturday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("               1  2 ");
                    Console.WriteLine("3  4  5  6  7  8  9 ");
                    Console.WriteLine("10 11 12 13 14 15 16");
                    Console.WriteLine("17 18 19 20 21 22 23");
                    Console.WriteLine("24 25 26 27 28      ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 7){
                    //Console.WriteLine("Sunday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("                  1 ");
                    Console.WriteLine("2  3  4  5  6  7  8 ");
                    Console.WriteLine("9  10 11 12 13 14 15");
                    Console.WriteLine("16 17 18 19 20 21 22");
                    Console.WriteLine("23 24 25 26 27 28   ");
                    Console.WriteLine("                    ");
                }
                else
                    Console.WriteLine("What?");
            }
            else if (nry == 30 && nm != 2){
                if (nd == 1){
                    //Console.WriteLine("Monday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("1  2  3  4  5  6  7 ");
                    Console.WriteLine("8  9  10 11 12 13 14");
                    Console.WriteLine("15 16 17 18 19 20 21");
                    Console.WriteLine("22 23 24 25 26 27 28");
                    Console.WriteLine("29 30               ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 2){
                    //Console.WriteLine("Tuesday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("   1  2  3  4  5  6 ");
                    Console.WriteLine("7  8  9  10 11 12 13");
                    Console.WriteLine("14 15 16 17 18 19 20");
                    Console.WriteLine("21 22 23 24 25 26 27");
                    Console.WriteLine("28 29 30            ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 3){
                    //Console.WriteLine("Wednesday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("      1  2  3  4  5 ");
                    Console.WriteLine("6  7  8  9  10 11 12");
                    Console.WriteLine("13 14 15 16 17 18 19");
                    Console.WriteLine("20 21 22 23 24 25 26");
                    Console.WriteLine("27 28 29 30         ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 4){
                    //Console.WriteLine("Thursday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("         1  2  3  4 ");
                    Console.WriteLine("5  6  7  8  9  10 11");
                    Console.WriteLine("12 13 14 15 16 17 18");
                    Console.WriteLine("19 20 21 22 23 24 25");
                    Console.WriteLine("26 27 28 29 30      ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 5){
                    //Console.WriteLine("Friday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("            1  2  3 ");
                    Console.WriteLine("4  5  6  7  8  9  10");
                    Console.WriteLine("11 12 13 14 15 16 17");
                    Console.WriteLine("18 19 20 21 22 23 24");
                    Console.WriteLine("25 26 27 28 30      ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 6){
                    //Console.WriteLine("Saturday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("               1  2 ");
                    Console.WriteLine("3  4  5  6  7  8  9 ");
                    Console.WriteLine("10 11 12 13 14 15 16");
                    Console.WriteLine("17 18 19 20 21 22 23");
                    Console.WriteLine("24 25 26 27 28 30   ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 7){
                    //Console.WriteLine("Sunday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("                  1 ");
                    Console.WriteLine("2  3  4  5  6  7  8 ");
                    Console.WriteLine("9  10 11 12 13 14 15");
                    Console.WriteLine("16 17 18 19 20 21 22");
                    Console.WriteLine("23 24 25 26 27 28 30");
                    Console.WriteLine("                    ");
                }
                else
                    Console.WriteLine("What?");
            }
            else{
                 if (nd == 1){
                    //Console.WriteLine("Monday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("1  2  3  4  5  6  7 ");
                    Console.WriteLine("8  9  10 11 12 13 14");
                    Console.WriteLine("15 16 17 18 19 20 21");
                    Console.WriteLine("22 23 24 25 26 27 28");
                    Console.WriteLine("29 30 31            ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 2){
                    //Console.WriteLine("Tuesday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("   1  2  3  4  5  6 ");
                    Console.WriteLine("7  8  9  10 11 12 13");
                    Console.WriteLine("14 15 16 17 18 19 20");
                    Console.WriteLine("21 22 23 24 25 26 27");
                    Console.WriteLine("28 29 30 31         ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 3){
                    //Console.WriteLine("Wednesday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("      1  2  3  4  5 ");
                    Console.WriteLine("6  7  8  9  10 11 12");
                    Console.WriteLine("13 14 15 16 17 18 19");
                    Console.WriteLine("20 21 22 23 24 25 26");
                    Console.WriteLine("27 28 29 30 31      ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 4){
                    //Console.WriteLine("Thursday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("         1  2  3  4 ");
                    Console.WriteLine("5  6  7  8  9  10 11");
                    Console.WriteLine("12 13 14 15 16 17 18");
                    Console.WriteLine("19 20 21 22 23 24 25");
                    Console.WriteLine("26 27 28 29 30 31   ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 5){
                    //Console.WriteLine("Friday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("            1  2  3 ");
                    Console.WriteLine("4  5  6  7  8  9  10");
                    Console.WriteLine("11 12 13 14 15 16 17");
                    Console.WriteLine("18 19 20 21 22 23 24");
                    Console.WriteLine("25 26 27 28 30 31   ");
                    Console.WriteLine("                    ");
                }
                else if (nd == 6){
                    //Console.WriteLine("Saturday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("               1  2 ");
                    Console.WriteLine("3  4  5  6  7  8  9 ");
                    Console.WriteLine("10 11 12 13 14 15 16");
                    Console.WriteLine("17 18 19 20 21 22 23");
                    Console.WriteLine("24 25 26 27 28 30 31");
                    Console.WriteLine("                    ");
                }
                else if (nd == 7){
                    //Console.WriteLine("Sunday");
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                    Console.WriteLine("                  1 ");
                    Console.WriteLine("2  3  4  5  6  7  8 ");
                    Console.WriteLine("9  10 11 12 13 14 15");
                    Console.WriteLine("16 17 18 19 20 21 22");
                    Console.WriteLine("23 24 25 26 27 28 30");
                    Console.WriteLine("31                  ");
                }
                else
                    Console.WriteLine("What?");
            }
            Console.WriteLine("<Press Enter To Continue>");
            // Wait before closing
            Console.ReadKey();
        }
    }
}
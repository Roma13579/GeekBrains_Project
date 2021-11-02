/*                                                           2 Урок "Базовые типыв С#"
*                                                    Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №4
 *     Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических, 
 *     по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были заранее заготовлены до вывода на консоль.

 */
using System;

namespace DZ_GB_Lesson_2__4
{
    class Program
    {
        enum specifications
        {
            DATE_TIME,
            ATM_NUMBER,
            CARDS_NUMBER,
            SEQUENCE_NUMBER,
            WITHDRAWAL_FROM,
            ACCOUNT_ENDING_WITH,
            AMOUNT,
            AVALIBLE_BALANCE,
            PRESENT_BALANCE,
           
        }
        static void Main(string[] args)
        {
            int x = 1;
            int c = 3087;
            int phone = 900;
            int atm_Numb = 3784;
            int sequen_Numb = 4059;
            string first = "FIRST AVENUE";
            string nyc = "N.Y.C";
            string ny = "NY";
            string withdrawal = "CHECKING";
            int account = 0065;
            double n = 220.00;
            double b = 3456.567;
            double a = 5670.00;


            switch (x)
            {
                case 1:
                    Console.WriteLine($"{phone} {first} \t\t{nyc} \t\t ,{ny} \n");
                    goto case 2;
                case 2:
                    Console.WriteLine($"{specifications.DATE_TIME}: \t\t\t {specifications.ATM_NUMBER}:");
                    goto case 3;
                case 3:
                    Console.WriteLine($"{DateTime.Now} \t\t {ny} {atm_Numb}"); ;
                    goto case 4;
                case 4:
                    Console.WriteLine($"{specifications.CARDS_NUMBER}: ************{c}\n");
                    goto case 5;
                case 5:
                    Console.WriteLine($"{specifications.SEQUENCE_NUMBER}: \t\t {sequen_Numb}");
                    goto case 6;
                case 6:
                    Console.WriteLine($"{specifications.WITHDRAWAL_FROM}: \t\t {withdrawal}");
                    goto case 7;
                case 7:
                    Console.WriteLine($"{specifications.ACCOUNT_ENDING_WITH}: \t\t XXXXXXXXXXX{account} \n ");
                    goto case 8;
                case 8:
                    Console.WriteLine($"{specifications.AMOUNT}: \t\t\t {n} $  ");
                    goto case 9;
                case 9:
                    Console.WriteLine($"{specifications.AVALIBLE_BALANCE}: \t\t {b} $ ");
                    goto case 10;
                case 10:
                    Console.WriteLine($"{specifications.PRESENT_BALANCE}: \t\t {a} $");
                    break;
            }
        }
    }
}

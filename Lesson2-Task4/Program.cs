using System;

namespace Lesson2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameShop = "ЕВРОТОРГ";
            string adress = "г.Гродно ул.Горького 55";
            int kodeUNP = 500838837;
            double sum = 0;

            string[] nameProd = { "Сыр творожный САВУШКИН", "Зефир ПЕРВЫЙ БОБРУЙСКИЙ", "Сметана БРЕСТ ЛИТОВСКАЯ",
                "Чай Greenfield", "Молоко МОЛОЧНЫЙ МИР", "Пакет-майка" };
            double[] price = { 3.65, 2.69, 2.16, 4.79, 1.29, 0.30 };

            Console.WriteLine($"Магазин {nameShop}"); ; ;
            Console.WriteLine(adress);
            Console.WriteLine($"Код УНП {kodeUNP}");
            Console.WriteLine($"Код УНП {kodeUNP}\n");

            for (int i = 0; i < nameProd.Length; i++)
                Console.WriteLine("{0, 10} {1,5:N1}", nameProd[i], price[i]);

            for (int i = 0; i < price.Length; i++)
                sum = sum + price[i];
            Console.WriteLine($"Сумма покупок  {Math.Round(sum, 2)}");
            Console.WriteLine($"Итого к оплате  {Math.Round(sum, 2)}");

            Console.WriteLine($"Оплачено (Банк. карта) {Math.Round(sum, 2)}\n");
            Console.WriteLine($"СПАСИБО ЗА ПОКУПКУ");
            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }
}

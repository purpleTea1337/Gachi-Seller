using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace IyS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание товаров
            Tovar Tovar1 = new Tovar();
            Tovar1.name = "Slave";
            Tovar1.PurchasePrice = 50;
            Tovar1.SellingPrice = 55;

            Tovar Tovar2 = new Tovar();
            Tovar2.name = "Cum";
            Tovar2.PurchasePrice = 60;
            Tovar2.SellingPrice = 65;

            Tovar Tovar3 = new Tovar();
            Tovar3.name = "Van";
            Tovar3.PurchasePrice = 55;
            Tovar3.SellingPrice = 60;


            //Массив с названием товаров
            string[] TovarNames = new string[3];
            TovarNames[0] = Tovar1.name;
            TovarNames[1] = Tovar2.name;
            TovarNames[2] = Tovar3.name;

            //Массив с ценами покупки товаров
            int[] TovarPurchaisePrice = new int[3];
            TovarPurchaisePrice[0] = Tovar1.PurchasePrice;
            TovarPurchaisePrice[1] = Tovar2.PurchasePrice;
            TovarPurchaisePrice[2] = Tovar3.PurchasePrice;

            //Массив с ценами продажи товаров
            int[] TovarSellingPrice = new int[3];
            TovarSellingPrice[0] = Tovar1.SellingPrice;
            TovarSellingPrice[1] = Tovar2.SellingPrice;
            TovarSellingPrice[2] = Tovar3.SellingPrice;

            //Массив с количеством товара
            int[] TovarNumber = new int[3];
            TovarNumber[0] = Tovar1.number;
            TovarNumber[1] = Tovar2.number;
            TovarNumber[2] = Tovar3.number;
            

            //Значения на старте игры
            int money = 50;


            //Настройки игры
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            int move = 0;
            while (true)
            {
                Console.WriteLine("-------------------------------------------");
                move++;
                string ChoiceOfAction = Actions.sq(move, money, TovarNumber, TovarNames); //статистика + выбор действия
                string ChoiceOfTovar = Actions.cfc(TovarNames, TovarPurchaisePrice, TovarSellingPrice, ChoiceOfAction); //продажа/покупка товаров

                //получение данных о товаре для записи данных из метода
                int ChoiceOfTovarInt = Convert.ToInt32(ChoiceOfTovar);
                ChoiceOfTovarInt--;
                //Создание массива для получения данных из метода
                int[] data = new int[2];

                //тот самый метод
                data = Actions.ybr(ChoiceOfAction, ChoiceOfTovar, TovarPurchaisePrice, TovarSellingPrice, TovarNumber, money);

                //конвертация данных полученных из метода
                money = data[0];
                TovarNumber[ChoiceOfTovarInt] = data[1];
            }
        }
    }
}

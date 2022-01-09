using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IyS
{
    class Actions
    {
        //Выюор действия
        static public string sq(int move, int money, int[] TovarNumber, string[] TovarNames)
        {
            Console.WriteLine("Ход: " + move);
            Console.WriteLine("Деньги: " + money);
            for(int i = 0; i < TovarNames.Length; i++)
            {
                Console.WriteLine("Количество " + TovarNames[i] + ": " + TovarNumber[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Выбирите действие:");
            Console.WriteLine("1: Покупка товара");
            Console.WriteLine("2: Продажа товара");

            string choice = Console.ReadLine();
            return choice;
        }
        


        //Выбор товара для покупки/продажи
        static public string cfc( string[] TovNames, int[] TovPurchPrice, int[] TovSellPrice, string ActChoice)
        {
            Console.WriteLine("");
            switch (ActChoice)
            {
                case "1":
                    {
                        for (int i = 0; i < TovNames.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ": Товар " + TovNames[i] + "(" + TovPurchPrice[i] + ")");
                        }
                        break;
                    }

                case "2":
                    {
                        for (int i = 0; i < TovNames.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ": Товар " + TovNames[i] + "(" + TovSellPrice[i] + ")");
                        }
                        break;
                    }

                default:
                    Console.WriteLine("ый");
                    return null;
            }
            
            string choice = Console.ReadLine();
            return choice;
        }



        static public int[] ybr(string СhoiceOfAction, string ChoiceOfTovar, int[] TovPurchPrice, int[] TovSellPrice, int[] TovarNumber, int money)
        {
            //поиск индекса товара
            int ChoiceOfTovarInt = Convert.ToInt32(ChoiceOfTovar);
            ChoiceOfTovarInt--;
            for (int i = 0; i > 20; i++ )
            {
                if (ChoiceOfTovarInt == TovPurchPrice[i])
                {
                    ChoiceOfTovarInt = i;
                    break;
                }
            }
            //
            int[] data = new int[2];
            data[0] = money;
            data[1] = TovarNumber[ChoiceOfTovarInt];

            //действия с товарами
            switch (СhoiceOfAction)
            {
                //покупка товара
                case "1":
                    {
                        if (money >= TovPurchPrice[ChoiceOfTovarInt])
                        {
                            data[0] = money - TovPurchPrice[ChoiceOfTovarInt];
                            data[1]++;
                            return data;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно денег!");
                        }
                        break;
                    }
                //продажа товара
                case "2":
                    {
                        if (TovarNumber[ChoiceOfTovarInt] > 0)
                        {
                            data[0] = money + TovSellPrice[ChoiceOfTovarInt];
                            data[1]--;
                            return data;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно товара!");
                        }
                        break;
                    }

                default:
                    Console.WriteLine("ый");
                    return data;
            }
            return data;
        }
    }
}

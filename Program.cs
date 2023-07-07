using System;
using System.Collections.Generic;
namespace Currencies_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            decimal board=1,recieved,given;
            int day=0,change;
            Dictionary<string,decimal> changes=new Dictionary<string, decimal>();
            bool a;
            while (true)
            {
                a=true;
                day++;
                change=0;
                while (true)
                {
                    change++;
                    recieved=0;
                    given=0;
                    Console.WriteLine("Коя валута се обменя? Опции: EUR,USD,GDP,TRY,RSD,RUB или нещо друго, ако е приключил работният ден");
                    switch (Console.ReadLine())
                    {
                        case("EUR"):board=1.965m;break;
                        case("USD"):board=1.96m;break;
                        case("GDP"):board=1.965m;break;
                        case("TRY"):board=1.965m;break;
                        case("RSD"):board=1.965m;break;
                        case("RUB"):board=1.965m;break;
                        default:a=false;break;
                    }
                    if(a==false)break;
                    Console.WriteLine("Какво количество се обменя?");
                    recieved=decimal.Parse(Console.ReadLine());
                    Console.WriteLine("От лева към чужда валута или обратно? Напишете 1 за избор от лева към чужда валута или нещо друго за избор от чужда валута към лева");
                    if (Console.ReadLine() == "1")
                    {
                        given=recieved/100/board;
                        Console.WriteLine($"Трябва да се дадат на клиента {Math.Round(given,2)}");
                    }
                    else
                    {
                        given=recieved/100*board;
                        Console.WriteLine($"Трябва да се дадат на клиента {Math.Round(given,2)} лева");
                    }
                    changes.Add($"{day}.{change}",recieved-given);                    
                }
                Console.WriteLine("Обмени за деня във формат ден.обмен спечелени пари");
                foreach(KeyValuePair<string,decimal> kvp in changes)Console.WriteLine(kvp.Key+" "+Math.Round(kvp.Value),2);
            }
        }
    }
}

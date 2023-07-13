using System;
using System.Collections.Generic;
namespace Currencies_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            decimal course=1,recieved,given;
            int day=0,change;
            Dictionary<string,decimal> changes=new Dictionary<string, decimal>();
	    string a;
            while (true)
            {
		day++;
                change=0;
                while (true)
                {
                    Console.Clear();
		    change++;
                    recieved=0;
                    given=0;
                    Console.WriteLine("От лева към чужда валута или обратно? Напишете 1 за избор от лева към чужда валута, 2 за избор от чужда валута към лева или нещо друго, ако е приключил работният ден");
	            a=Console.ReadLine();
                    if (a == "1")
                    {
	                    Console.WriteLine("\nКоя валута се обменя? Опции: EUR,PLN,USD,GBP,TRY,RSD,RUB,RON,BRL,HUF,IDR,MKD,MXN,UAH или нещо друго за друга валута");
        	            switch (Console.ReadLine())
                	    {
                        	case("EUR"):course=1.965m;break;
                         	case("PLN"):course=0.444m;break;
	                        case("USD"):course=1.785m;break;
        	                case("GBP"):course=2.292m;break;
                	        case("TRY"):course=0.0723m;break;
                        	case("RSD"):course=0.0177m;break;
	                        case("RUB"):course=0.0205m;break;
	                        case("RON"):course=0.404m;break;
	                        case("BRL"):course=3.83m;break;
	                        case("HUF"):course=5.28m;break;
	                        case("IDR"):course=1.243m;break;
	                        case("MKD"):course=0.0329m;break;
	                        case("MXN"):course=0.1093m;break;
	                        case("UAH"):course=0.047m;break;
				default:Console.Write("\nКурс: ");course=decimal.Parse(Console.ReadLine());break;
                	    }
			    Console.WriteLine("\nКакво количество се обменя?");
			    recieved=decimal.Parse(Console.ReadLine());
			    given=recieved/course;
			    Console.WriteLine($"\nТрябва да се дадат на клиента {Math.Round(given,2)}");
                    	    changes.Add($"{day}.{change}",recieved);                    
                    }
                    else if(a=="2")
                    {
	                    Console.WriteLine("\nКоя валута се обменя? Опции: EUR,PLN,USD,GBP,TRY,RSD,RUB,RON,BRL,HUF,IDR,MKD,MXN,UAH или нещо друго за друга валута");
        	            switch (Console.ReadLine())
                	    {
                        	case("EUR"):course=1.95m;break;
                        	case("PLN"):course=0.427m;break;
	                        case("USD"):course=1.761m;break;
        	                case("GBP"):course=2.259m;break;
                	        case("TRY"):course=0.0698m;break;
                        	case("RSD"):course=0.0167m;break;
	                        case("RUB"):course=0.0165m;break;
	                        case("RON"):course=0.391m;break;
				case("BRL"):course=3.69m;break;
	                        case("HUF"):course=5.06m;break;
	                        case("IDR"):course=1.125m;break;
	                        case("MKD"):course=0.0319m;break;
	                        case("MXN"):course=0.0989m;break;
	                        case("UAH"):course=0.043m;break;
				default:Console.Write("\nКурс: ");course=decimal.Parse(Console.ReadLine());break;
                	    }
                    	    Console.WriteLine("\nКакво количество се обменя?");
                    	    recieved=decimal.Parse(Console.ReadLine());
                            given=recieved*course;
                            Console.WriteLine($"\nТрябва да се дадат на клиента {Math.Round(given,2)} лева");
                    	    changes.Add($"{day}.{change}",given);                    
                    }
		    else break;
		    Console.ReadKey();
                }
                Console.WriteLine("\nОбмени за деня във формат ден.обмен обменени лева");
                foreach(KeyValuePair<string,decimal> kvp in changes)Console.WriteLine(kvp.Key+" "+Math.Round(kvp.Value),2);
		Console.ReadKey();
            }
        }
    }
}

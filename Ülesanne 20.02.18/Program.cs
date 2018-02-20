using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_20._02._18
{
    class Program
    {
        static void Main(string[] args)
        {
            var Autod1 = new List<Auto>()
            {
                new Auto(){ Kw = 250, Mudel = "Rs6", Tootja = "Audi", Värv = "Sinine"},
                new Auto(){ Kw = 200, Mudel = "Rs4", Tootja = "Audi", Värv = "Punane"},
                new Auto(){ Kw = 400, Mudel = "R8", Tootja = "Audi", Värv = "Hall"},
                new Auto(){ Kw = 240, Mudel = "m4", Tootja = "bmw", Värv = "Must"},
                new Auto(){ Kw = 178, Mudel = "X5", Tootja = "bmw", Värv = "Must"},
                new Auto(){ Kw = 500, Mudel = "LaFerrari", Tootja = "Ferrari", Värv = "Punane"},
                new Auto(){ Kw = 150, Mudel = "Model S", Tootja = "Tesla", Värv = "Valge"},
                new Auto(){ Kw = 400, Mudel = "Aventador", Tootja = "Lamborghini", Värv = "Kollane"},
                new Auto(){ Kw = 900, Mudel = "Veyron", Tootja = "Bugatti", Värv = "Valge"},
                new Auto(){ Kw = 800, Mudel = "one", Tootja = "Koenigsegg", Värv = "Hall"},
            };

            Console.WriteLine("Autod KW järjestuses:");
            Console.WriteLine("");
            var query = (from element in Autod1
                         orderby element.Kw ascending
                         select element).ToList();

            foreach(var item in query)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.Värv +":" + " " + item.Kw + "KW");
            }
            

            var o = Autod1.Where(x => x.Tootja.Contains("o")).ToList();
            var e = Autod1.Where(x => x.Tootja.Contains("e")).ToList();
            var MoreThanFour = Autod1.Where(x => x.Mudel.Length > 4).ToList();
            var MaxCarKw = Autod1.Max(x => x.Kw);
            var MinCarKw = Autod1.Min(x => x.Kw);

            Console.WriteLine("");
            Console.WriteLine("Autod mille tootja nimes on täht 'o':");
            Console.WriteLine("");

            foreach(var item in o)
            {
                Console.WriteLine(item.Tootja);
            }

            Console.WriteLine("");
            Console.WriteLine("Autod mille tootja nimes on täht 'e':");
            Console.WriteLine("");

            foreach( var item in e)
            {
                Console.WriteLine(item.Tootja);
            }

            Console.WriteLine("");
            Console.WriteLine("Autode mudelid kus on rohkem kui neli tähte:");
            Console.WriteLine("");

            foreach (var item in MoreThanFour)
            {
                Console.WriteLine(item.Mudel);
            }

            Console.WriteLine("");
            Console.WriteLine("Kõige võimsama auto Kw on:");
            Console.WriteLine("");

            Console.WriteLine(MaxCarKw);

            Console.WriteLine("");
            Console.WriteLine("Kõige nõrgema auto Kw on:");
            Console.WriteLine("");

            Console.WriteLine(MinCarKw);

            Console.ReadLine();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephones
{
    class Program
    {
        private static TelephoneController telephones;
        private static FirmaController firms;

        static void Main(string[] args)
        {
            telephones = new TelephoneController();
            firms = new FirmaController();

            Console.WriteLine("Это тестовая програма");

            while (true)
            {
                Menu(telephones, firms);
            }
            
        }

        private static void Menu(TelephoneController telephones, FirmaController firms)
        {
            Console.WriteLine();
            Console.WriteLine("Что бы вывести список телефонов введите: all firm");
            Console.WriteLine("Что бы вывести список телефонов введите: all tel");
            Console.WriteLine("Что бы создать новую фирму введите: create firma");
            Console.WriteLine("Что бы создать новый телефон введите: create telephone");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "all firm": PrintFirm(); break;
                case "all tel": PrintTel(); break;
                case "create firma": CreateFirma(); break;
                case "create telephone": CreateTelephone(telephones, firms); break;
            }
        }


        private static void PrintFirm()
        {
            foreach (Firma aFirms in firms.GetFirms())
            {
                Console.WriteLine(aFirms.ToString());
            }
            
        }

        private static void PrintTel()
        {
            foreach (Telephone aTel in telephones.Telephones())
            {
                Console.WriteLine(aTel.ToString());
            }
        }

        private static void CreateFirma()
        {
            Console.WriteLine("Введите имя фирмы:");
            string nFirm = Console.ReadLine();
            try
            {
                firms.Add(nFirm);
                PrintFirm();
            }
            catch
            { 
                Console.WriteLine("ошибка");
            }
        }

        private static void CreateTelephone(TelephoneController tephones, FirmaController firms)
        {
            Console.WriteLine("Введите модель телефона:");
            string modele = Console.ReadLine();

            Console.WriteLine("Введите стоимость:");
            int stoimost = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Список фирм:");
            PrintFirm();

            Console.WriteLine("Введите фирму:");
            string firma = Console.ReadLine();

            telephones.AddTelephone(modele, stoimost, firma, firms);

        }


    }
}

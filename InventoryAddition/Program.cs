using System;
using System.Collections.Generic;

namespace InventoryAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhone = PhoneInitialisation();

            Console.Write("Unesi marku mobitela koji zelis pronaci: ");
            var input = Console.ReadLine();
            Console.WriteLine();

            var inputAsInt = InputAsInt(input);

            var exists = false;
            switch (inputAsInt)
            {
                case 1:
                    foreach (var i in myPhone)
                    {
                        if (i.Manufacturer == Manufacturer.Samsung)
                        {
                            i.Print();
                            exists = true;
                        }
                    }

                    if(!exists)
                        Console.WriteLine("Proizvod tog prodavaca ne postoji!");

                    break;

                case 2:
                    foreach (var i in myPhone)
                    {
                        if (i.Manufacturer == Manufacturer.Apple)
                        {
                            i.Print();
                            exists = true;
                        }
                    }

                    if (!exists)
                        Console.WriteLine("Proizvod tog prodavaca ne postoji!");

                    break;

                case 3:
                    foreach (var i in myPhone)
                    {
                        if (i.Manufacturer == Manufacturer.Xiaomi)
                        {
                            i.Print();
                            exists = true;
                        }
                    }

                    if (!exists)
                        Console.WriteLine("Proizvod tog prodavaca ne postoji!");

                    break;

                case 4:
                    foreach (var i in myPhone)
                    {
                        if (i.Manufacturer == Manufacturer.Huawei)
                        {
                            i.Print();
                            exists = true;
                        }
                    }

                    if (!exists)
                        Console.WriteLine("Proizvod tog prodavaca ne postoji!");

                    break;

                case 5:
                    foreach (var i in myPhone)
                    {
                        if (i.Manufacturer == Manufacturer.HTC)
                        {
                            i.Print();
                            exists = true;
                        }
                    }

                    if (!exists)
                        Console.WriteLine("Proizvod tog prodavaca ne postoji!");

                    break;

                case 6:
                    foreach (var i in myPhone)
                    {
                        if (i.Manufacturer == Manufacturer.Nokia)
                        {
                            i.Print();
                            exists = true;
                        }
                    }

                    if (!exists)
                        Console.WriteLine("Proizvod tog prodavaca ne postoji!");

                    break;

                default:
                    Console.WriteLine("Pogresan unos - taj proizvodac ne postoji!");
                    
                    break;

            }
        }

        static List<Phone> PhoneInitialisation()
        {
            var myPhone = new List<Phone>()
            {
                new Phone("Prvi Mobitel", 1000, Manufacturer.Samsung),
                new Phone("Drugi Mobitel", 2000, Manufacturer.Xiaomi),
                new Phone("Treci Mobitel", 3000, Manufacturer.Xiaomi),
                new Phone("Cetvrti Mobitel", 4000, Manufacturer.Samsung),
                new Phone("Peti Mobitel", 1500, Manufacturer.Apple),
                new Phone("Sesti Mobitel", 2500, Manufacturer.Huawei),
                new Phone("Sedmi Mobitel", 3500, Manufacturer.Nokia),
                new Phone("Osmi Mobitel", 4500, Manufacturer.Xiaomi),
                new Phone("Deveti Mobitel", 5000, Manufacturer.Xiaomi),
                new Phone("Deseti Mobitel", 1000, Manufacturer.Nokia),
            };

            Console.WriteLine("Postojece marke: \n");
            Console.WriteLine(Manufacturer.Samsung);
            Console.WriteLine(Manufacturer.Apple);
            Console.WriteLine(Manufacturer.Xiaomi);
            Console.WriteLine(Manufacturer.Huawei);
            Console.WriteLine(Manufacturer.HTC);
            Console.WriteLine(Manufacturer.Nokia);
            Console.WriteLine();

            return myPhone;
        }

        static int InputAsInt(string input)
        {
            switch (input.ToLower())
            {
                case "samsung":

                    return 1;

                case "apple":

                    return 2;

                case "xiaomi":

                    return 3;

                case "huawei":

                    return 4;

                case "htc":

                    return 5;

                case "nokia":

                    return 6;

                default:

                    return 0;
            }
        }
    }

    public class Phone
    {
        public Phone(string description,int price, Manufacturer manufacturer)
        {
            Description = description;
            Price = price;
            Manufacturer = manufacturer;
        }

        public string Description { get; set; }
        public int Price { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public void Print()
        {
            Console.WriteLine("Opis: " + Description);
            Console.WriteLine("Cijena: " + Price);
            Console.WriteLine("Marka: " + Manufacturer);
            Console.WriteLine();
        }
    }

    public enum Manufacturer
    {
        Samsung=1,
        Apple=2,
        Xiaomi=3,
        Huawei=4,
        HTC=5,
        Nokia=6
    }
}

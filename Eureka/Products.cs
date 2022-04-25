using System;

namespace Eureka
{
    static partial class Program
    {
        static Products GetProduct()
        {
            Console.WriteLine("What Product Do You Want?");
            Console.WriteLine("1: Basketball");
            Console.WriteLine("2: Hockey");
            Console.WriteLine("3: Volleyball");
            Console.WriteLine("4: Soccer");
            Console.WriteLine("5: Baseball");
            Console.WriteLine("6: Softball");
            Console.WriteLine("7: Wrestling");
            Console.WriteLine("8: Futsal");
            Console.WriteLine("9: Signage");
            Console.WriteLine("10: Safety");
            Console.WriteLine("11: Fleet");
            Console.WriteLine("12: POS");
            int Product = 0;
            do
            {
                var ProductStr = Console.ReadLine();
                Int32.TryParse(ProductStr, out Product);
            } while (Product == 0 || Product > 12 || Product < 0);

            switch (Product)
            {
                case 1:
                    return Products.Basketball;
                case 2:
                    return Products.Hockey;
                case 3:
                    return Products.Handball;
                case 4:
                    return Products.Volleyball;
                case 5:
                    return Products.Soccer;
                case 6:
                    return Products.Baseball;
                case 7:
                    return Products.Softball;
                case 8:
                    return Products.Wrestling;
                case 9:
                    return Products.Futsal;
                case 10:
                    return Products.Signage;
                case 11:
                    return Products.Safety;
                case 12:
                    return Products.Fleet;
                case 13:
                    return Products.POS;
            }

            return Products.Baseball;
        }
        enum Products
        {
            Basketball = 2001,
            Hockey = 1918,
            Handball = 1299,
            Volleyball = 1951,
            Soccer = 3866,
            Baseball = 3851,
            Softball = 3851,
            Wrestling = 6,
            Futsal = 87319,
            Signage = 87319,
            Safety = 87319,
            Fleet = 0,
            POS = 49183,
        }
    }
}
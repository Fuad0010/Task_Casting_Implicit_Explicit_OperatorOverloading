using System;

namespace Task_Casting_Implicit_Explicit_OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        enum Currency
        {
            Usd,
            Eur,
            Try
        }

        public static double Exchange(Enum Currency1, double azn)
        {
            if (Currency1 is Currency)
            {
                switch(Currency1)
                {
                    case Currency.Usd:
                        {
                            azn /= 1.7;
                        }
                        break;
                    case Currency.Eur:
                        {
                            azn *= 2;
                        }
                        break;
                    case Currency.Try:
                        {
                            azn *= 1.8;
                        }
                        break;
                }   
            }return azn;
        }

    }
}

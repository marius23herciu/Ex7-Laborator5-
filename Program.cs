using System;

namespace Ex7_Laborator5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 7
            //Scrieti un program care va citi doua siruri de caractere de la tastatura si va
            //verifica daca cele doua siruri de caractere sunt anagrame.

            Console.WriteLine("Introduceti primul sir.");
            string sir1 = CitesteSir();
            Console.WriteLine("Introduceti al doilea sir.");
            string sir2 = CitesteSir();

            sir1 = EliminareSpatiiGoale(sir1);
            sir2 = EliminareSpatiiGoale(sir2);

            if (sir1.Length != sir2.Length)
            {
                Console.WriteLine("Sirurile introduse NU sunt anagrame.");
                return;
            }

            bool rezultat = VerificareAnagrama(sir1, sir2);
            if (rezultat == true)
            {
                Console.WriteLine("Sirurile introduse sunt anagrame.");
            }
            else
            {
                Console.WriteLine("Sirurile introduse NU sunt anagrame.");
            }
        }
        static string CitesteSir()
        {
            string sir = Console.ReadLine();
            return sir;
        }
        static bool VerificareAnagrama(string sir1, string sir2)
        {
            bool rezultat = true;
            char[] sirDeCaractere1 = OrdonareCaractere(sir1);
            char[] sirDeCaractere2 = OrdonareCaractere(sir2);

            for (int i = 0; i < sirDeCaractere1.Length; i++)
            {
                if (sirDeCaractere1[i] != sirDeCaractere2[i])
                {
                    rezultat = false;
                    break;
                }
            }

            return rezultat;
        }
        static char[] OrdonareCaractere(string sir)
        {
            char[] sirDeCaractere = sir.ToCharArray();
            for (int i = 0; i < sirDeCaractere.Length; i++)
            {
                for (int j = 0; j < sirDeCaractere.Length; j++)
                {
                    if (sirDeCaractere[i] > sirDeCaractere[j])
                    {
                        char aux = sirDeCaractere[i];
                        sirDeCaractere[i] = sirDeCaractere[j];
                        sirDeCaractere[j] = aux;
                    }
                }
            }

            return sirDeCaractere;
        }
        static string EliminareSpatiiGoale(string sir)
        {
            string modificat = string.Empty;
            for (int i = 0; i < sir.Length; i++)
            {
                if (sir[i] != ' ')
                {
                    modificat += sir[i];
                }
            }

            return modificat;
        }

    }
}

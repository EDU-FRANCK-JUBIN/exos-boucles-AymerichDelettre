using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOR ------>");
            List<int> listMult2 = new List<int>();
            for(int i = 0; i<20; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("WHILE ------>");
            int y = 0;
            while(y < 20)
            {
                if(y % 2 == 0)
                {
                    Console.WriteLine(y);
                }
                y++;
            }

            int valeur;
            Console.WriteLine("Saisir une valeur : ");
            Int32.TryParse(Console.ReadLine(), out valeur);
            int somme = 0;
            for(int i = 0; i<= valeur;i++)
            {
                somme += i;
            }
            Console.WriteLine("Somme : " + somme);


            Console.WriteLine("Veuillez saisir 5 nombres : ");
            int valeurEx2;
            int sommeEx2 = 0;
            double moyenne;
            Int32.TryParse(Console.ReadLine(), out valeurEx2);
            sommeEx2 += valeurEx2;
            Int32.TryParse(Console.ReadLine(), out valeurEx2);
            sommeEx2 += valeurEx2;
            Int32.TryParse(Console.ReadLine(), out valeurEx2);
            sommeEx2 += valeurEx2;
            Int32.TryParse(Console.ReadLine(), out valeurEx2);
            sommeEx2 += valeurEx2;
            Int32.TryParse(Console.ReadLine(), out valeurEx2);
            sommeEx2 += valeurEx2;

            moyenne = sommeEx2 / 5;
            Console.WriteLine("Moyenne des nombres : " + moyenne);

            Console.WriteLine("Somme entiers entre 1 et 10 : " + CalculSommeEntiers(1, 10));
            Console.WriteLine("Somme entiers entre 1 et 100 : " + CalculSommeEntiers(1, 100));

            List<double> liste = new List<double>() { 1,5.5,9.9,2.8,9.6};
            Console.WriteLine("Moyenne de la liste : " + CalculMoyenneListe(liste));

            Exo5();
            Console.ReadLine();


            //5 nombres:
            //methode calcul moyenne
        }
        public static int CalculSommeEntiers(int x,int y)
        {
            int somme = 0;
            for (int i = x; i <= y; i++)
            {
                somme += i;
            }
            return somme;
        }

        public static double CalculMoyenneListe(List<double> list)
        {
            double somme = 0;
            double moyenne = 0;

            foreach(double ite in list)
            {
                somme += ite;
            }
            moyenne = somme / list.Count();

            return moyenne;
        }

        public static void Exo5()
        {
            List<int> listeMult3 = new List<int>();
            List<int> listeMult5 = new List<int>();
            int somme = 0;

            for (int i = 3; i < 100; i+=3)
            {
                listeMult3.Add(i);
            }

            for (int i = 5; i < 100; i += 5)
            {
                listeMult5.Add(i);
            }

            foreach(int element in listeMult3)
            {
                if(listeMult5.Contains(element))
                {
                    somme += element * 2;
                }
            }

            Console.WriteLine("Somme elements communs : " + somme);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLaba01
{   
    public class Sinus
    {
        public double Ugol;
        public double SinUgla;
        
    }
    class Program
    {
        static int KolStol(int[,] mass)
        {
            int i, j, kolvo = 0;
            bool flag = true;
            int N1 = mass.GetLength(0);
            int N2 = mass.GetLength(1);

            for (i = 0; i < mass.GetLength(1); i++)
            {
                for (j = 0; j < mass.GetLength(0); j++)
                {
                    if (mass[j, i] == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    kolvo++;
                }
                flag = true;
            }
            return (kolvo);
        }
        static void first()
        { 
            int Num, i;
            Console.WriteLine("Введите количество элементов массива: ");
            Num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[Num];
            Random random = new Random();
            Console.WriteLine("Элементы массива: ");
            for (i = 0; i < Num; i++)
            {
                array[i] = random.Next(-1500, -1000);
                Console.Write(array[i]);
                Console.Write(" ");
            }
            //var minimum = ;
            Console.WriteLine($"\nМинимальный элемент в массиве: {array.Min()}");
            Console.ReadKey();

        }//1zadanye
        static void second()
        {
            int N1, N2, kolvo;
            Console.WriteLine("Введите количество строк массива: ");
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива: ");
            N2 = Convert.ToInt32(Console.ReadLine());
            int[,] mass2 = new int[N1, N2];
            Random random = new Random();
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N1; i++)
            {
                for (int j = 0; j < N2; j++)
                {
                    mass2[i, j] = random.Next(0, 10);
                    Console.Write(mass2[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            kolvo = KolStol(mass2);
            Console.WriteLine($"\nКоличество столбцов в массиве, не содержащих 0: {kolvo}");
            Console.ReadKey();
        }//2zadanye
        static void third()
        {
            //sinus.Add(new Sinus() { Ugol = 0, SinUgla = 0 });
            //sinus.Add(new Sinus() { Ugol = 30, SinUgla = 0.5 });
            //sinus.Add(new Sinus() { Ugol = 90, SinUgla = 1 });
            //sinus.Add(new Sinus() { Ugol = 180, SinUgla = 0 });
            //sinus.Add(new Sinus() { Ugol = 270, SinUgla = -1 });
            //sinus.Add(new Sinus() { Ugol = 360, SinUgla = 0 });

            Console.WriteLine("Введите кол-во углов:");
            int kolvo_uglov = Convert.ToInt32(Console.ReadLine());
            List<Sinus> sinus = new List<Sinus>(kolvo_uglov);
            //int[] arr_ugol = new int[kolvo_uglov];
            Console.WriteLine("Введите углы:");
            for (int i = 0; i < kolvo_uglov; i++)
            {
                double grad_ugol = Convert.ToDouble(Console.ReadLine());
                //arr_ugol[i] = grad_ugol;
                sinus.Add(new Sinus() { Ugol = grad_ugol, SinUgla = Math.Sin(0.0175*grad_ugol) });

            }

            foreach (Sinus sin in sinus)
            {
                Console.WriteLine($"Угол: {sin.Ugol}, Синус угла: {sin.SinUgla} ");
            }
            foreach (Sinus sin in sinus.Where(sin => sin.SinUgla > 0.5))
            {
                Console.WriteLine($"\nУгол, синус которого больше, чем 0.5: {sin.Ugol} Синус этого угла:{sin.SinUgla}");
            }
            Console.ReadKey();
        }//3zadanye
        static void Main(string[] args)
        {
            int num_task = 0;
            for (; ; )
            {
                Console.WriteLine("Выберите номер задания(1-3):");
                num_task = Convert.ToInt32(Console.ReadLine());
                if (num_task == 1) first();
                if (num_task == 2) second();
                if (num_task == 3) third();
                Console.WriteLine("Вы хотите выйти?\nДа-1\nНет-2");
                int exit = Convert.ToInt32(Console.ReadLine());
                if (exit == 1) break;
                Console.Clear();
            }
        }
    }
    
}

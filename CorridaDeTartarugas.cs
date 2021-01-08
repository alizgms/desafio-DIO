using System;
using System.Linq;

    class corridaDeTartarugas {

        static void Main(string[] args) {

            int max = 0;
            int limite = 0;

            while (limite < 3) {

                int V = Convert.ToInt32(Console.ReadLine());
                int[] velocidade = new int[V];
                string[] aux = Console.ReadLine().Split();

                for (int i = 0; i < aux.Length; i++) {
                    velocidade[i] = Convert.ToInt32(aux[i]);
                }

                max = velocidade.Max();

                if (max < 10) {
                    Console.WriteLine(1);
                } else if (max < 20) {
                    Console.WriteLine(2);
                } else if (max >= 20) {
                    Console.WriteLine(3);
                }
                limite++;
            }
        }
    }
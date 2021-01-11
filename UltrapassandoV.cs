using System;

class UltrapassandoV {
    static void Main () {

        var R = Int32.Parse(Console.ReadLine()); // recebe o valor de R
        var V = 0; // inicializa o valor de V
        var contador = 1; // inicializa o contador

        do {

            V = Int32.Parse(Console.ReadLine()); // recebe o valor de V, até que o valor de V seja menor ou igual a R

        } while (V <= R);

        int i = R; // "i" é usado como auxiliar

        while (i <= V) { 

            contador++; //enquanto o valor i for menor igual a V, o contador incrementa +1 

            R += 1; // R recebe o valor de R + 1
            i += R; // i recebe o valor de i + R 

        }

        Console.WriteLine(contador); // mostra a quantidade de vezes que foi necessário para fazer a ultrapassagem

    }
}
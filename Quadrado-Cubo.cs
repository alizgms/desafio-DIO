using System;


class Desafio {
   public static void Main() {
        var numero = Int32.Parse(Console.ReadLine());
        
        if(numero != null)
        {
          for(int i = 1; i <= numero; i++)
          {
           var numeros = $"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}";
            Console.WriteLine(numeros);
          }
        } else {
          Console.WriteLine("Insira um novo número entre 1 e 1000:");
        }
    }
}
using System;

class Desafio {
  static void Main() {

    var n1 = float.Parse(Console.ReadLine());

    while (n1 > 10 || n1 < 0)
    {
      Console.WriteLine("nota invalida");
      n1 = float.Parse(Console.ReadLine());
    }

    var n2 = float.Parse(Console.ReadLine());

    while (n2 > 10 || n2 < 0)
    {
      Console.WriteLine("nota invalida");
      n2 = float.Parse(Console.ReadLine());
    }

    var media = (n1 + n2) / 2;
    string teste = media.ToString("N2");

    Console.WriteLine("media = " + teste);
  }
}
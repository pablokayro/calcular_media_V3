using System;
using System.Linq;
using System.Collections.Generic;
class Aula17 
{
    static void Main(string[]args){

        double []notas=new double[4];
        string resultado;

        Console.Clear();
        Console.Write("Digite a 1° nota: ");
        notas[0] = double.Parse(Console.ReadLine());
        Console.Write("Digite a 2° nota: ");
        notas[1] = double.Parse(Console.ReadLine());
        Console.Write("Digite a 3° nota: ");
        notas[2] = double.Parse(Console.ReadLine());
        Console.Write("Digite a 4° nota: ");
        notas[3] = double.Parse(Console.ReadLine());

        double media = notas.Average(); //Calcula a média dos valores de uma lista

        if (media>=7 && media<=10 && media>=0){
            resultado="APROVADO!";
        }else if(media>=4 && media<=10 && media>=0){
            resultado="RECUPERAÇÃO!";
        }else if(media<4 && media<=10 && media>=0){
            resultado="REPROVADO!";
        }else{
            resultado="MÉDIA INVÁLIDA!";
        }
        Console.WriteLine($"Media: {media}\nResultado: {resultado}");
    }
}



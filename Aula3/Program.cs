using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula3{
    class Program{
        static void Main(string[] args){

            //início exercício 1
            Console.WriteLine("1) Faça um programa que leia o nome e as quatro notas de um aluno, calcule a média e ao final informe o nome do aluno, a média e se foi aprovado ou reprovado, considerando que a média para aprovação é sete.\n");
            int quantidade_notas = 4;
            float[] notas = new float[quantidade_notas];
            float nota_final = 0;
            string nome_aluno;
            Console.Write("Digite o nome do aluno: ");
            nome_aluno = Console.ReadLine();
            Console.Write("\n");
            for (int x = 0; x < notas.Length; x++){
                Console.Write("Prova {0}:",x+1);
                notas[x] = float.Parse(Console.ReadLine());
                nota_final += notas[x];
            }
            nota_final = nota_final / notas.Length;
            if (nota_final >= 5){
                Console.Write("\n{0} foi Aprovado! Média: {1}",nome_aluno,nota_final);
            }else{
                Console.Write("\n{0} foi Reprovado! Média: {1}", nome_aluno, nota_final);
            }
            //fim exercício 1

            Console.WriteLine("\n\n\n");

            //início exercício 2
            Console.WriteLine("2) Escreva um programa que leia um número e exiba mensagem informando se o numero é par ou ímpar.\n");
            Console.Write("Digite um número: ");
            int numero;
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0){
                Console.WriteLine("{0} é par!", numero);
            }else{
                Console.WriteLine("{0} é impar!", numero);
            }
            //fim exercício 2

            Console.WriteLine("\n\n\n");

            //início exercício 3
            Console.WriteLine("3) Escreva um programa que leia dois números e exiba mensagem informando se o primeiro número lido é múltiplo do segundo.\n");
            Console.Write("Digite o primeiro número: ");
            int primeiro_numero, segundo_numero;
            primeiro_numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            segundo_numero = int.Parse(Console.ReadLine());
            if (primeiro_numero % segundo_numero == 0){
                Console.WriteLine("\nO número {0} é múltiplo de {1}.", primeiro_numero, segundo_numero);
            }
            else{
                Console.WriteLine("\nO número {0} não é múltiplo de {1}.", primeiro_numero, segundo_numero);                
            }
            //fim exercício 3

            Console.WriteLine("\n\n\n");

            //início exercício 4
            Console.WriteLine("4) Escreva um programa que leia dois números e exiba mensagem informando o valor do maior numero e o valor do menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.\n");
            Console.Write("Digite o primeiro número: ");
            int ex4_primeiro_numero,ex4_segundo_numero;
            ex4_primeiro_numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            ex4_segundo_numero = int.Parse(Console.ReadLine());
            if (ex4_primeiro_numero > ex4_segundo_numero){
                Console.WriteLine("\n{0} é maior que {1}.", ex4_primeiro_numero,ex4_segundo_numero);
            }
            else if (ex4_primeiro_numero == ex4_segundo_numero){
                Console.WriteLine("\nOs números são iguais. Os dois são {0}", ex4_primeiro_numero);
            }else{
                Console.WriteLine("{0} é maior que {1}", ex4_segundo_numero, ex4_primeiro_numero);
            }
            //fim exercício 4

            Console.WriteLine("\n\n\n");

            //início exercício 5
            Console.WriteLine("5) Escreva um programa que leia três números inteiros e ao final exiba eles em ordem crescente.\n");
            int quantidade_numeros = 3;
            int[] numeros = new int[quantidade_numeros];
            for (int i = 1; i <= quantidade_numeros; i++){
                Console.Write("Digite o {0}º número:",i);
                numeros[i - 1] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.Write("\nNúmeros em ordem Crescente: ");
            for (int i = 1; i <= quantidade_numeros; i++){
                Console.Write("{0} ",numeros[i-1]);
            }
            Console.Write("\n");
            //fim exercício 5
        }
    }
}

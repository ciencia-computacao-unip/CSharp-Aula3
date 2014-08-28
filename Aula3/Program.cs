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
        }
    }
}

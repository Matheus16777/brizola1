using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   
    }
internal class Aluno
{
    public string nome;
    public int idade;
    public int alunos;
    public Aluno(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public int Idade
    {
        get
        {
            return idade;

        }
        set
        {
            if (value > 0 && value <= 20)
            {
                idade = value;
            }
            else
            {
                throw new Exception("Valor invalido para idade");
            }


        }
    }

    public Aluno(string nome, int idade, int aluno)
    {
        this.nome = nome;
        this.idade = idade;
        alunos = aluno;
    }
    private double  nota1;
    private double nota2;

    private double media()
    {
        return (nota1 + nota2) / 2;
    }
    public void passouDeAno();
    {
      Console.WriteLine("Digite a 1 nota");
    nota1 = Convert.ToDouble(Console.ReadLine)());
    }

}



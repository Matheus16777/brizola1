namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno("Matheus", 18);
           
            Aluno aluno2 = new Aluno("Lucas",20);
           
            Console.WriteLine("Aluno 1");
            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.idade);

           



            Console.WriteLine("Aluno 2");
            Console.WriteLine(aluno2.nome);
            Console.WriteLine(aluno2.idade);

            aluno2.passouDeAno();




            Console.ReadLine();
        }
    }
}
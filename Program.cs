using System;


namespace Medias
{
    class Program
    {
        static void Main(string[] args)
        {

               Aluno aluno1 = new Aluno();

                Console.WriteLine("Digite o nome do aluno:");
                aluno1.nome = Console.ReadLine();

                Console.WriteLine("Insira o nome do curso: ");
                aluno1.curso = Console.ReadLine();

                Console.WriteLine("Insira a idade do aluno:");
                aluno1.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o RG do aluno");
                aluno1.RG = Console.ReadLine();


                Console.WriteLine("O aluno é bolsista? (S/N)");
                string resposta = Console.ReadLine();

                if(resposta == "s" || resposta == "S"){
                    aluno1.bolsista = true;

                } else if(resposta == "n" || resposta == "N"){
                    aluno1.bolsista = false;
                }

                Console.WriteLine("Insira a média do aluno:");
                aluno1.mediaFinal = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o valor da mensalidade:");
                aluno1.ValorDaMensalidade = double.Parse(Console.ReadLine());

               
                Console.WriteLine(aluno1.nome);
                Console.WriteLine(aluno1.curso);
                Console.WriteLine(aluno1.idade);
                Console.WriteLine(aluno1.RG);
                Console.WriteLine(aluno1.bolsista);
                //Console.WriteLine(aluno1.mediaFinal);
                //Console.WriteLine(aluno1.valorDaMensalidade);
                

                aluno1.VerMediaFinal(aluno1.mediaFinal);
                aluno1.VerMensalidade(aluno1.bolsista, aluno1.valorDaMensalidade);
        }
    }

    internal class Aluno
    {
        internal string nome;
        internal string curso;
        internal int idade;
        internal bool bolsista;
        internal double mediaFinal;
        internal object valorDaMensalidade;

        public string RG { get; internal set; }
        public double ValorDaMensalidade { get; internal set; }

        internal void VerMediaFinal(double mediaFinal)
        {
            throw new NotImplementedException();
        }

        internal void VerMensalidade(bool bolsista, object valorDaMensalidade)
        {
            throw new NotImplementedException();
        }
    }
}

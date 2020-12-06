using System;

namespace Medias.Classes
{
    public class alunos
    {
        
        public string nome;
        public string curso;
        public int idade;
        public string RG;
        public bool bolsista;
        public double mediaFinal;
        public double valorDaMensalidade;
        public void VerMediaFinal(double media){
            Console.WriteLine($"Média do aluno: {media}");
        }

        public void VerMensalidade(bool temBolsa, double mensalidade){
            if (temBolsa == true)
            {
                Console.WriteLine("Este aluno é bolsista");
                Console.WriteLine($"Mensalidade sem desconto aicional: {mensalidade}");

                Console.WriteLine($"Mensalidade com desconto: {0.7 * mensalidade}");

            } else{
                Console.WriteLine("Este aluno não é bolsista");
                Console.WriteLine($"Mensalidade:{mensalidade}");
            }
        }

    }
}
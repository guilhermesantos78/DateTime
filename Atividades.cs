using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    public class Atividades
    {
        public void Atividade1()
        {
            Console.WriteLine("Qual é a sua data de nascimento ?");
            DateTime DataNascimento = DateTime.Parse(Console.ReadLine());

            DateTime hoje = DateTime.Now;

            int dt1 = DataNascimento.Year;

            int dt2 = hoje.Year;

            int resultado = dt2 - dt1;


            if (DataNascimento.Month > hoje.Month)
            {
                Console.WriteLine("resultado");
            }
            else if (DataNascimento.Month == hoje.Month && DataNascimento.Second > hoje.Second)
            {
                Console.WriteLine($"Idade : {resultado} ");
            }
            else
            {
                Console.WriteLine($" Idade : {resultado - 1}");
            }

        }
        public void Atividade2()
        {
            Console.WriteLine("Qual é a sua data de nascimento ?");
            DateTime DataNascimento = DateTime.Parse(Console.ReadLine());

            DateTime hoje = DateTime.Now;

            if (DataNascimento.Month == hoje.Month && DataNascimento.Day == hoje.Day)
            {
                Console.WriteLine("hoje é seu aniversario!");
            }
            else
            {
                Console.WriteLine("hoje não é seu aniversario!");
            }



        }
        public void Atividade3()
        {
            Console.WriteLine("Qual é a sua data de nascimento ?");
            DateTime DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(DataNascimento.ToString("dd/MM/yyyy HH:mm"));
        }
    }

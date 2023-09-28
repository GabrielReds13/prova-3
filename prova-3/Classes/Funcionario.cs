using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3.Classes
{
    public class Funcionario
    {
        // Atributos
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

        public int Matricula { get; set; }
        public double Salario { get; set; }

        // Metodo construtor
        public Funcionario
        (
            string nome,
            string cpf,
            DateTime dataNascimento,
            string sexo,
            int matricula,
            double salario
        ) 
        {
            Nome = nome; 
            Cpf = cpf; 
            Salario = salario;
            DataNascimento = dataNascimento;
            Sexo = sexo;

            Matricula = matricula;
            Salario = salario;
        }

        // Metodos
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3.Classes
{
    public class Medico : Funcionario
    {
        // Atributos
        public string Crm { get; set; }
        public double ValorHoraExtra { get; set; }
        public double Beneficio { get; set; }
        public string Especialidade { get; set; }

        // Metodo construtor
        public Medico
        (
            // Atributo funcionario
            string nome,
            string cpf,
            DateTime dataNascimento,
            string sexo,
            int matricula,
            double salario,

            // Atributo medico
            string crm,
            double valorHoraExtra,
            string especialidade

        ) : base
        (
            nome,
            cpf,
            dataNascimento,
            sexo,
            matricula,
            salario
        )
        {
            // Atributos
            Crm = crm;
            Especialidade = especialidade;

            // Financeiro
            Beneficio = salario * 0.22;
            ValorHoraExtra = valorHoraExtra;
            Salario = salario + Beneficio + ValorHoraExtra;
        }

        // Metodos
    }
}

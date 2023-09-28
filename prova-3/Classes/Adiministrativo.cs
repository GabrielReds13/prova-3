using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3.Classes
{
    public class Adiministrativo : Funcionario
    {
        // Atributos
        public double ValeAlimentacao { get; set; }
        public double ValeTransporte { get; set; }

        // Metodo construtor
        public Adiministrativo
        (
            // Atributo funcionario
            string nome,
            string cpf,
            DateTime dataNascimento,
            string sexo,
            int matricula,
            double salario
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
            // Financeiro
            ValeAlimentacao = salario * 0.17;
            ValeTransporte = 250;
            Salario = salario + ValeTransporte + ValeAlimentacao;
        }
        // Metodos
    }
}

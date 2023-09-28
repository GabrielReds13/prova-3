using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_3.Classes
{
    public static class Sistema
    {
        // Atributo
        public static List<Medico> Medicos { get; set; }
        public static List<Adiministrativo> Adiministrativos { get; set; }
        public static List<Funcionario> Funcionarios { get; set; }

        // Metodos
        public static void CadastrarFuncionario
        (
            // Funcionario
            string nome,
            string cpf,
            DateTime dataNascimento,
            string sexo,
            double salario,
            string tipo,

            // Medico
            string crm,
            double valorHoraExtra,
            string especialidade
        )
        {
            try
            {
                // Gerar matricula
                Random n = new Random();
                int matricula = n.Next(100000, 999999);

                // Criar funcionario
                if(tipo == null)
                {
                    Funcionario f = new Funcionario
                    (
                        nome, 
                        cpf,
                        dataNascimento,
                        sexo, 
                        matricula,
                        salario
                    );

                    Funcionarios.Add(f);
                }
                else if (tipo == "Médico")
                {
                    Medico m = new Medico
                    (
                        nome,
                        cpf,
                        dataNascimento,
                        sexo,
                        matricula,
                        salario,
                        crm,
                        valorHoraExtra,
                        especialidade
                    );

                    Medicos.Add(m);
                }
                else if (tipo == "Adiministrativo")
                {
                    Adiministrativo a = new Adiministrativo
                    (
                        nome,
                        cpf,
                        dataNascimento,
                        sexo,
                        matricula,
                        salario
                    );

                    Adiministrativos.Add(a);
                }
            }
            catch( Exception ex )
            {
                Console.WriteLine("ERR0R: Não foi possível cadastrar novo funcionário");
            }
        }

        public static void ListarFuncionarios()
        {
            Console.WriteLine(" - FUNCIONÁRIOS -");
            foreach( Funcionario f in Funcionarios ) { Console.WriteLine($"NOME: {f.Nome} | CPF: {f.Cpf} | MATRÍCULA: {f.Matricula} | SALÁRIO: {f.Salario}"); }
            Console.WriteLine(" - MÉDICOS -");
            foreach( Medico f in Medicos ) { Console.WriteLine($"NOME: {f.Nome} | CPF: {f.Cpf} | MATRÍCULA: {f.Matricula} | CRM: {f.Crm} | ESPECIALIDADE: {f.Especialidade} | SALÁRIO: {f.Salario} | BENEFÍCIO: {f.Beneficio} | VALOR H.E: {f.ValorHoraExtra}"); }
            Console.WriteLine(" - ADIMINISTRATIVOS -");
            foreach( Adiministrativo f in Adiministrativos ) { Console.WriteLine($"NOME: {f.Nome} | CPF: {f.Cpf} | MATRÍCULA: {f.Matricula} | SALÁRIO: {f.Salario} | V. ALIMENTAÇÃO: {f.ValeAlimentacao} | V. TRANSPORTE: {f.ValeTransporte}"); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Entity;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Programador func1 = new Programador();
            func1.Departamento = new Departamento();
            func1.IdFuncionario = 1;
            func1.Nome = "Joselito";
            func1.Salario = 3500.0M;
            func1.Departamento.IdDepartamento = 1;
            func1.Departamento.Nome = "Webdeveloper";
            func1.Tipo = "Programador C# jr";

            Programador func2 = new Programador(2, "Josivaldo", 2500.0M, "Desenvolvedor Frontend");
            func2.Departamento= new Departamento(2, "Webdesign");

            Console.WriteLine("\nDados do Funcionario1:");
            Console.WriteLine("Id.................: " + func1.IdFuncionario);
            Console.WriteLine("Nome...............: " + func1.Nome);
            Console.WriteLine("Salario............: " + func1.Salario);
            Console.WriteLine("Cod Departamento...: " + func1.Departamento.IdDepartamento);
            Console.WriteLine("Nome Departamento..: " + func1.Departamento.Nome);
            Console.WriteLine("Tipo...............: " + func1.Tipo);

            Console.WriteLine("\nDados do Funcionario2:");
            Console.WriteLine("Id.................: " + func2.IdFuncionario);
            Console.WriteLine("Nome...............: " + func2.Nome);
            Console.WriteLine("Salario............: " + func2.Salario);
            Console.WriteLine("Cod Departamento...: " + func2.Departamento.IdDepartamento);
            Console.WriteLine("Nome Departamento..: " + func2.Departamento.Nome);
            Console.WriteLine("Tipo...............: " + func2.Tipo);

            Console.ReadKey();
        }
    }
}

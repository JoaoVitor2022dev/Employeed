using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main()
        {
           // 1 - entrada de dados 
           Console.Write("How many employees will be registered ?");
           int N = int.Parse(Console.ReadLine()); 
    
           List<Funcionario> lista = new List<Funcionario>();

           for (int i = 0; i < N; i++)
           { 
             int position = i + 1; 
             Console.WriteLine("Emplyoes #{0}", position);
             Console.WriteLine(" ");

              Console.Write("Id: ");
              int id = int.Parse(Console.ReadLine());

              Console.Write("Name: ");
              string name = Console.ReadLine();

              Console.Write("Salary: ");
              double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         
              lista.Add(new Funcionario(id, name, salary));

              Console.WriteLine(" ");
           }  

           // processamento 
             
           Console.Write("Enter the employee id that will have salary incrase: ");  
           int id_  = int.Parse(Console.ReadLine()); 
           
           Funcionario funcionario = lista.Find(x => x.Id == id_);
 
           if (funcionario != null)
           {
              Console.Write("Enter com a porcentage: ");
              int porcentagem = int.Parse(Console.ReadLine());
              funcionario.IncreaseSalary(porcentagem);
           } else {
              Console.Write("Id nao encontrado!");
           }

           // saida de dados
           Console.WriteLine("Update salaries:"); 

           foreach(Funcionario obj in lista )
           {
              Console.WriteLine(" Id: {0}, nome: {1}, ${2} ", obj.Id, obj.Name, obj.Salario.ToString("F2", CultureInfo.InvariantCulture));
           }
        }
    }
}



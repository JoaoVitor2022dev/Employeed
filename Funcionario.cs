using System;
using System.Globalization;

namespace Primeiro
{
    class Funcionario
    {
         public int Id { get; set; }
         public string Name { get; private set; }
         public double Salario { get; private set; } 

         public Funcionario(int id, string name, double salario)
         {
            Id = id; 
            Name = name;
            Salario = salario;
         }

         public void IncreaseSalary(int porcentagem)
         {
           Salario += Salario * porcentagem / 100.0;
         }

         public override string ToString()
         {
            return  ID + ", " + Name + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture) + " ."
         }
    }
}

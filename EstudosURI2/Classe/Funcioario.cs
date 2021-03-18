using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EstudosURI2.Classe
{
    class Funcioario
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Funcioario(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percent)
        {
            Salary += Salary * percent / 100;
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Salary;
        }
    }
}


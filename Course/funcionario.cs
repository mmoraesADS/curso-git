using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; private set; }

        public funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double aumento) {
            Salario *= (aumento + 1);

        }
        override
        public string ToString() => $"\nID: {Id} \nNome: {Nome} \nSalário: {Salario}";

    }
}

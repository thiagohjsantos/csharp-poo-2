﻿using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario : IBonificacao
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
    }
}

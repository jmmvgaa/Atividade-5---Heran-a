﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5___Herança
{
    class Operario : Colaborador
    {
        private double valorProducao;
        private int comissao;


        public Operario(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {

        }
        public double ValorProducao
        {
            get { return valorProducao; }
            set { valorProducao = value; }
        }
        public int Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        public override double calcularSalario()
        {
            double valorFinal = valorProducao - (valorProducao + (double)Comissao / 100);
            return base.calcularSalario() + valorFinal;

        }
    }
}
    


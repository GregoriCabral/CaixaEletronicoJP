using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Transacao
    {
        public string Quando { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public int CodigoConta { get; set; }

        public double Sacar(Transacao transacao, double saldoBd)
        {

            if (saldoBd < transacao.Valor)
            {
                return -1;
            }
            else
            {
                double saldoFinal = saldoBd - transacao.Valor;
                return saldoFinal;
            }

        }

        public double Depositar(Transacao transacao, double saldoBd)
        {

            double depositar = transacao.Valor + saldoBd;

            return depositar;
        }

    }
}

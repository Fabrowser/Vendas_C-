using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade
{
    class Venda
{
    private static int qtd;
    private static double valor;

    #region Getter & Setters

    public int Qtd { get => qtd; set => qtd = value; }
    public double Valor { get => valor; set => valor = value; }

    #endregion

    public double valorMedio()
    {
        return valor / qtd;
    }
}
}
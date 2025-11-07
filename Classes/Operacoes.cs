using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Classes
{
    internal class Operacoes
    {
        double x, y;
        public Operacoes()
        {
            x = 0; y = 0;
        }

        //Getters e Setters

        public void setXFromInput(double x)
        {
            this.x = x;
        }

        public double getX()
        {
            return this.x;
        }
        public double getY()
        {
            return this.y;
        }
        public void setYFromInput(double y)
        {
            this.y = y;
        }

        public double soma()
        {
            return this.x + this.y;
        }
        public double subtracao()
        {
            return this.x - this.y;

        }

        public double multiplicacao()
        {
            return this.x * this.y;
        }

        public double divisao()
        {
            return this.x / this.y;
        }

        public double valorQuadrado()
        {
            return this.x * this.x;
        }

        public double raizQuadrada()
        {
            return this.x / this.x;
        }

        public double porcentagem()
        {
            return (this.x / 100) * this.y;
        }

        public double binario()
        {
            long value = (long)this.x;

            if (value <= 0)
            {
                return 0000;
            }
            else
            {
                String restos = "";
                while (value > 0)
                {
                    restos += value % 2;
                    value = value / 2;
                }
                String resultadoBinario = "";
                for (int i = restos.Length - 1; i >= 0; i--)
                {
                    resultadoBinario += restos[i];
                }
                return long.Parse(resultadoBinario);
            }

        }

        public double raizY()
        {
            int count = 0;
            double result = this.x;

            while (count < (this.y - 1))
            {
                result *= this.x;
                count++;
            }
            return result;
        }

        public string apagar()
        {
            return "";

        }


    }
}
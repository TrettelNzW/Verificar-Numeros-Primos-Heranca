using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPrimo.Modelo
{
    internal class Primo : AbsPropriedades
    {
        public Primo(int num)
        {
            this.num = num;
            this.Verificar();
        }

        private void Verificar()
        {
            this.mensagem = "É Primo";

            if (num <= 1)
            {
                mensagem = "Não é Primo";
                return;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    mensagem = "Não é Primo";
                    break;
                }
            }
        }
    }
}


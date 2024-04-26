using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificarPrimo.Modelo
{
    internal class Controle : AbsPropriedades
    {
        public Controle(string numero)
        {
            this.numero = numero;
            this.Executar();
        }
        private void Executar()
        {
            Validacao validacao = new Validacao(numero);
            if (validacao.mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.n1);
                this.mensagem = primo.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
   }
}





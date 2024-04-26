using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VerificarPrimo.Modelo
{
	internal class Validacao : AbsPropriedades
	{
		public Validacao(string numero)
		{
			this.numero = numero;
			this.Validar();
		}
		private void Validar()
		{
			this.mensagem = "";
			try
			{
                this.n1 = Convert.ToInt32(this.numero);
            }
			catch(Exception ex)
			{
				this.mensagem = "Digite um número valido";
			}
		}
	}
}

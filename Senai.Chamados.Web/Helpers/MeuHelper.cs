using System;

namespace Senai.Chamados.Web.Helpers
{
	public class MeuHelper
	{
		public static string DireitosReservados() {
			return "©" + DateTime.Now.Year + "- Senai - Todos os direitos reservados";
		}

		public static string BoasVindas() {
			return "Seja Bem vindo, ";
		}

	
	}
}
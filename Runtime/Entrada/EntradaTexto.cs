using Ging1991.Interfaces.Salida;
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Entrada {

	public class EntradaTexto : MarcoConTexto {

		public GameObject entradaOBJ;


		public override void SetColorTexto(Color color) {
			entradaOBJ.GetComponent<Text>().color = color;
			textoOBJ.GetComponent<Text>().color = color;
		}


	}

}
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Salida {

	public class MarcoConTexto : Marco {

		public GameObject textoOBJ;

		public virtual void SetColorTexto(Color color) {
			textoOBJ.GetComponent<Text>().color = color;
		}


		public void SetTexto(string texto) {
			textoOBJ.GetComponent<Text>().text = texto;
		}

	}

}
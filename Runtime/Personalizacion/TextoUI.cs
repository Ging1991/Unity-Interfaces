using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Personalizacion {

	public class TextoUI : MonoBehaviour {

		public Text textoOBJ;
		public string codigo;

		public void SetTexto(string texto) {
			if (textoOBJ != null)
				textoOBJ.text = texto;
			else
				Debug.LogWarning("No se ha asignado un objeto de texto.");
		}

		public void SetColor(Color color) {
			if (textoOBJ != null)
				textoOBJ.color = color;
			else
				Debug.LogWarning("No se ha asignado un objeto de texto.");
		}

	}

}
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Personalizacion {

	public class ColorUI : MonoBehaviour {

		public Image imagenOBJ;
		public string codigo;

		public void SetColor(Color color) {
			if (imagenOBJ != null)
				imagenOBJ.color = color;
			else
				Debug.LogWarning("No se ha asignado un objeto de imagen.");
		}

	}

}
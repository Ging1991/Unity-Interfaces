using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Personalizacion {

	public class ColorUI : MonoBehaviour {

		public Graphic objetivo;
		public string codigo;

		public void SetColor(Color color) {
			if (objetivo != null)
				objetivo.color = color;
			else
				Debug.LogWarning("No se ha asignado un objetivo de tipo Graphic.");
		}

	}

}
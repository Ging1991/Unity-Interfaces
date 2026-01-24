using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Selecciones {

	public class OpcionBinaria : Alternador {

		public Sprite imgActivado, imgDesactivado;
		public Image imagenOBJ;

		protected override void SetVisual() {
			imagenOBJ.sprite = valor ? imgActivado : imgDesactivado;
		}

	}

}
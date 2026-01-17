using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Contadores {

	public class ContadorNumero : MarcoConTexto {

		public int valor;
		public Image imagenFrente;
		public Image imagenFondo;

		public void SetValor(int valor) {
			this.valor = valor;
			SetTexto($"{valor}");
		}

		public void SetImagenFrente(Sprite sprite) {
			imagenFrente.sprite = sprite;
		}

		public void SetImagenFondo(Sprite sprite) {
			imagenFondo.sprite = sprite;
		}

	}

}
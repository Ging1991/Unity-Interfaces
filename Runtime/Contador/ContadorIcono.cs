using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Contadores {

	public class ContadorIcono : MonoBehaviour {

		public int valor;
		public Image imagen;
		public Text texto;
		public RectTransform rectTransform;

		public void SetValor(int valor) {
			this.valor = valor;
			texto.text = $"{valor}";
		}

		public void SetImagen(Sprite sprite) {
			imagen.sprite = sprite;
		}

		public void SetColorFuente(Color color) {
			texto.color = color;
		}

		public void SetDimensiones(float ancho, float alto) {
			rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, ancho);
			rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, alto);
		}

	}

}
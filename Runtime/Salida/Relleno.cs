using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Salida {

	public class Relleno : MonoBehaviour {

		public void SetImagenRelleno(Sprite imagen) {
			GetComponent<Image>().sprite = imagen;
		}


		public virtual void SetColorRelleno(Color color) {
			GetComponent<Image>().color = color;
		}

	}

}
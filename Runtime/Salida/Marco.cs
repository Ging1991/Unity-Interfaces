using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Salida {

	public class Marco : Relleno {

		public GameObject rellenoOBJ;

		public void SetColorBorde(Color color) {
			GetComponent<Image>().color = color;
		}


		public override void SetColorRelleno(Color color) {
			rellenoOBJ.GetComponent<Image>().color = color;
		}

	}

}
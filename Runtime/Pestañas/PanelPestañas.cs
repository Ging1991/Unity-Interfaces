using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Interfaces.Pestañas {

	public class PanelPestañas : MonoBehaviour {

		public Color colorActivado;
		public Color colorDesactivado;

		public List<Pestaña> pestañas;

		public void ActivarPestaña(Pestaña pestañaActivada) {
			foreach (var pestaña in pestañas) {
				pestaña.contenido.SetActive(false);
				pestaña.imagenBoton.color = colorDesactivado;
			}
			pestañaActivada.contenido.SetActive(true);
			pestañaActivada.imagenBoton.color = colorActivado;
			pestañaActivada.transform.SetAsFirstSibling();
		}

	}

}
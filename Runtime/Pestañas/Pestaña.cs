using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Pestañas {

	public class Pestaña : MonoBehaviour {

		public PanelPestañas padre;
		public GameObject contenido;
		public Image imagenBoton;

		public void PresionarBoton() {
			padre.ActivarPestaña(this);
		}

	}

}
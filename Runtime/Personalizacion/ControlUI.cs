using Ging1991.Core.Interfaces;
using UnityEngine;

namespace Ging1991.Interfaces.Personalizacion {

	public class ControlUI : MonoBehaviour {

		private IProveedor<string, Color> proveedorColores;
		private IProveedor<string, string> proveedorTextos;

		public void Inicializar(IProveedor<string, Color> proveedorColores, IProveedor<string, string> proveedorTextos) {
			this.proveedorColores = proveedorColores;
			this.proveedorTextos = proveedorTextos;
		}

		public void ActualizarUI() {
			ActualizarColores(FindObjectsByType<ColorUI>(FindObjectsInactive.Include, FindObjectsSortMode.None));
			ActualizarTextos(FindObjectsByType<TextoUI>(FindObjectsInactive.Include, FindObjectsSortMode.None));
		}

		public void ActualizarUI(GameObject instancia) {
			ActualizarColores(instancia.GetComponentsInChildren<ColorUI>(true));
			ActualizarTextos(instancia.GetComponentsInChildren<TextoUI>(true));
		}

		private void ActualizarTextos(TextoUI[] componentes) {
			foreach (TextoUI componente in componentes) {
				if (!string.IsNullOrEmpty(componente.codigo))
					componente.SetTexto(proveedorTextos.GetElemento(componente.codigo));
			}
		}

		private void ActualizarColores(ColorUI[] componentes) {
			foreach (ColorUI componente in componentes) {
				if (!string.IsNullOrEmpty(componente.codigo))
					componente.SetColor(proveedorColores.GetElemento(componente.codigo));
			}
		}

	}

}
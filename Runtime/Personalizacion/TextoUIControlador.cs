using Ging1991.Core.Interfaces;
using UnityEngine;

namespace Ging1991.Interfaces.Personalizacion {

	public class TextoUIControlador : MonoBehaviour {

		private IProveedor<string, string> proveedor;

		public void Inicializar(IProveedor<string, string> proveedor) {
			this.proveedor = proveedor;
		}

		public void Actualizar() {
			foreach (TextoUI texto in FindObjectsByType<TextoUI>(FindObjectsSortMode.None)) {
				texto.SetTexto(proveedor.GetElemento(texto.codigo));
			}
		}

	}

}
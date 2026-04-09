using Ging1991.Core.Interfaces;
using UnityEngine;

namespace Ging1991.Interfaces.Personalizacion {

	public class ColorUIControlador : MonoBehaviour {

		private IProveedor<string, Color> proveedor;

		public void Inicializar(IProveedor<string, Color> proveedor) {
			this.proveedor = proveedor;
		}

		public void Actualizar() {
			foreach (ColorUI color in FindObjectsByType<ColorUI>(FindObjectsSortMode.None)) {
				color.SetColor(proveedor.GetElemento(color.codigo));
			}
		}

	}

}
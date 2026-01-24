using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Interfaces.Selecciones {

	public class GrupoDeRadio : MonoBehaviour, IAlternadorObservador {

		public List<AlternadorRadio> opciones;
		private List<IAlternadorObservador> observadores;

		public void Iniciar() {
			observadores = new List<IAlternadorObservador>();
			foreach (var opcion in opciones) {
				opcion.AgregarObservador(this);
			}
		}


		public void AgregarObservador(IAlternadorObservador observador) {
			observadores.Add(observador);
		}


		public List<string> GetOpcionesActivas() {
			List<string> ret = new List<string>();
			foreach (var opcion in opciones) {
				if (opcion.valor == true)
					ret.Add(opcion.codigo);
			}
			return ret;
		}


		public void AlternadorPresionado(Alternador alternador) {
			foreach (IAlternadorObservador observador in observadores) {
				observador.AlternadorPresionado(alternador);
			}
			AlternadorRadio alternadorRadio = (AlternadorRadio)alternador;

			foreach (var opcion in opciones) {
				if (opcion == alternadorRadio)
					continue;
				opcion.Desactivar();
			}

		}


	}

}
using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Interfaces.Selecciones {

	public class GrupoDeCasillas : MonoBehaviour, IAlternadorObservador {

		public List<OpcionBinaria> opciones;
		private List<IAlternadorObservador> observadores;
		public OpcionBinaria opcionTodo;
		public OpcionBinaria opcionNada;

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

			if (alternador.valor == true) {
				if (alternador == opcionTodo) {
					SetGlobal(true);
				}
				else if (alternador == opcionNada) {
					SetGlobal(false);
				}
			}

			if (alternador != opcionTodo && alternador != opcionNada && alternador.valor == true) {
				if (opcionNada != null && opcionNada.valor == true) {
					opcionNada.Presionar();
				}
			}
			if (alternador != opcionTodo && alternador != opcionNada && alternador.valor == false) {
				if (opcionTodo != null && opcionTodo.valor == true) {
					opcionTodo.Presionar();
				}
			}
		}


		private void SetGlobal(bool valor) {
			foreach (var opcion in opciones) {
				if (opcion == opcionTodo || opcion == opcionNada)
					continue;

				if (opcion.valor != valor) {
					opcion.Presionar();
				}
			}
		}


	}

}
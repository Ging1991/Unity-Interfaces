using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Interfaces.Selecciones {

	public abstract class Alternador : MonoBehaviour {

		public bool valor;
		public string codigo;
		private List<IAlternadorObservador> observadores;

		public void AgregarObservador(IAlternadorObservador observador) {
			observadores ??= new List<IAlternadorObservador>();
			observadores.Add(observador);
		}


		void OnMouseDown() {
			Presionar();
		}


		public virtual void Presionar() {
			valor = !valor;
			SetVisual();
			InformarObservadores();
		}


		protected abstract void SetVisual();


		protected void InformarObservadores() {
			if (observadores != null) {
				foreach (IAlternadorObservador observador in observadores) {
					observador.AlternadorPresionado(this);
				}
			}
		}


	}

}
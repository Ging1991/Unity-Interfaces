using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ging1991.Interfaces.Casillas {

	public class Casilla : MonoBehaviour {

		public Sprite imgActivado, imgDesactivado;
		public Image imagen;
		public bool valor;
		public string codigo;
		private List<ICasillaObservador> observadores;


		void Start() { }


		public void AgregarObservador(ICasillaObservador observador) {
			if (observadores == null) {
				observadores = new List<ICasillaObservador>();
			}
			observadores.Add(observador);
		}


		void OnMouseDown() {
			Presionar();
		}


		public void Presionar() {
			CambiarValor();
			InformarObservadores();
		}


		private void CambiarValor() {
			valor = !valor;
			imagen.sprite = valor ? imgActivado : imgDesactivado;
		}


		private void InformarObservadores() {
			if (observadores != null) {
				foreach (ICasillaObservador observador in observadores) {
					observador.PresionarCasilla(codigo, valor);
				}
			}
		}


		public static bool EstaActivada(string codigo) {
			GameObject[] arreglo = GameObject.FindGameObjectsWithTag("casilla");
			bool ret = false;
			for (var i = 0; i < arreglo.Length; i++) {
				Casilla casillaActual = arreglo[i].GetComponent<Casilla>();
				if (casillaActual.codigo == codigo)
					ret = casillaActual.valor;
			}
			return ret;
		}


	}

}
using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Interfaces.Casillas {

	public class GrupoDeCasillas : MonoBehaviour, ICasillaObservador {

		public List<Casilla> casillas;
		private List<ICasillaObservador> observadores;
		public string codigo;
		public Vector3 posicionVisible;
		public Vector3 posicionInvisible;
		public Casilla casillaTodo;
		public Casilla casillaNada;

		void Start() { }


		public void Iniciar() {
			observadores = new List<ICasillaObservador>();
			foreach (var casilla in casillas) {
				casilla.AgregarObservador(this);
			}
		}


		public void AgregarObservador(ICasillaObservador observador) {
			observadores.Add(observador);
		}


		public List<string> GetCasillasActivas() {
			List<string> ret = new List<string>();
			foreach (var casilla in casillas) {
				if (casilla.valor)
					ret.Add(casilla.codigo);
			}
			return ret;
		}


		public void PresionarCasilla(string codigo, bool valor) {
			foreach (ICasillaObservador observador in observadores) {
				observador.PresionarCasilla(codigo, valor);
			}

			if (casillaTodo != null) {
				// Si activa TODO, se activan todas las casillas del grupo
				if (casillaTodo.codigo == codigo && valor) {
					SetGlobal(true);
				}
				if (!EsGlobal(codigo) && !valor) {
					if (casillaTodo.valor) {
						casillaTodo.Presionar();
					}
				}
			}
			if (casillaNada != null) {
				// Si activa NADA, se desactivan todas las casillas del grupo
				if (casillaNada.codigo == codigo && valor) {
					SetGlobal(false);
				}
				if (!EsGlobal(codigo) && valor) {
					if (casillaNada.valor) {
						casillaNada.Presionar();
					}
				}

			}
		}


		private bool EsGlobal(string codigo) {
			if (casillaTodo != null && casillaTodo.codigo == codigo)
				return true;
			if (casillaNada != null && casillaNada.codigo == codigo)
				return true;
			return false;
		}


		private void SetGlobal(bool valor) {
			foreach (var casilla in casillas) {
				if (casilla == casillaTodo || casilla == casillaNada)
					continue;

				if (casilla.valor != valor) {
					casilla.Presionar();
				}
			}
		}


		public void MostrarGrupo() {
			transform.position = posicionVisible;
		}


		public void EsconderGrupo() {
			transform.localPosition = posicionInvisible;
		}


	}

}
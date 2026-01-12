using Ging1991.Core.Interfaces;
using Ging1991.Interfaces;
using Ging1991.Interfaces.Casillas;
using UnityEngine;

public class ControlInterfacesTest : MonoBehaviour, ICasillaObservador {

	public TextoSecuencial textoSecuencial;
	public GrupoDeCasillas grupoDeCasillas;

	public void PresionarCasilla(string codigo, bool valor) {
		Debug.Log($"Casilla {codigo}: {valor}");
	}

	void Start() {
		grupoDeCasillas.Iniciar();
		grupoDeCasillas.AgregarObservador(this);
		//textoSecuencial.SetTexto("Texto de prueba Texto de prueba Texto de prueba Texto de prueba Texto de prueba Texto de prueba", accion: new AccionFinalizar());
		//textoSecuencial.MostrarTextoCompleto();
	}

	public class AccionFinalizar : IEjecutable {
		public void Ejecutar() {
			Debug.Log("Accion completada");
		}
	}

}
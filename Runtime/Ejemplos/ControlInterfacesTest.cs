using Ging1991.Core.Interfaces;
using Ging1991.Interfaces;
using Ging1991.Interfaces.Casillas;
using Ging1991.Interfaces.Contadores;
using UnityEngine;

public class ControlInterfacesTest : MonoBehaviour, ICasillaObservador {

	public TextoSecuencial textoSecuencial;
	public GrupoDeCasillas grupoDeCasillas;
	public ContadorNumero contadorNumero;
	public ContadorIcono contadorNumero2;

	public Sprite sangre;

	public void PresionarCasilla(string codigo, bool valor) {
		Debug.Log($"Casilla {codigo}: {valor}");
	}

	void Start() {
		//grupoDeCasillas.Iniciar();
		//grupoDeCasillas.AgregarObservador(this);
		//textoSecuencial.SetTexto("Texto de prueba Texto de prueba Texto de prueba Texto de prueba Texto de prueba Texto de prueba", accion: new AccionFinalizar());
		//textoSecuencial.MostrarTextoCompleto();
		contadorNumero.SetValor(5);
		//contadorNumero.SetColorBorde(Color.blue);
		//contadorNumero.SetColorRelleno(Color.cyan);
		contadorNumero.SetImagenFrente(sangre);
		contadorNumero.SetImagenFondo(sangre);
		contadorNumero.SetColorTexto(Color.white);

		contadorNumero2.SetImagen(sangre);
		contadorNumero2.SetValor(9);
		contadorNumero2.SetColorFuente(Color.white);
		contadorNumero2.SetDimensiones(100, 100);

	}

	public class AccionFinalizar : IEjecutable {
		public void Ejecutar() {
			Debug.Log("Accion completada");
		}
	}

}
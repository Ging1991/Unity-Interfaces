namespace Ging1991.Interfaces.Selecciones {

	public class AlternadorRadio : OpcionBinaria {

		public override void Presionar() {
			valor = true;
			SetVisual();
			InformarObservadores();
		}


		public void Desactivar() {
			valor = false;
			SetVisual();
		}

	}

}
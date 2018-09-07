using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsDelhjugadorSeleccionadoEnPantalla : MonoBehaviour {


	public  int NuneroDePersonajeSeleccionadoD;
	public GameObject interfazJugador1; 
	public GameObject interfazJugador2;
	public GameObject interfazJugador3;
	public GameObject interfaJugador4;
	public GameObject interfazJugador5;






	void Start () {
		NuneroDePersonajeSeleccionadoD=cambiarPersonajeSeleccion.NuneroDePersonajeSeleccionado;


	


		if (NuneroDePersonajeSeleccionadoD == 1) {
			interfazJugador1.SetActive (true);
		} else {
			interfazJugador1.SetActive (false);
		}



		if (NuneroDePersonajeSeleccionadoD == 2) {
			interfazJugador2.SetActive (true);
		} else {
			interfazJugador2.SetActive (false);
		}


		if (NuneroDePersonajeSeleccionadoD == 3) {
			interfazJugador3.SetActive (true);
			} else{
			interfazJugador3.SetActive (false);
			}




		if (NuneroDePersonajeSeleccionadoD == 4) {
			interfaJugador4.SetActive (true);
			}else{
			interfaJugador4.SetActive (false);
			}





		if (NuneroDePersonajeSeleccionadoD == 5) {
			interfazJugador5.SetActive (true);
			}else{
					interfazJugador5.SetActive (false);
			}












	}
	





		
	}


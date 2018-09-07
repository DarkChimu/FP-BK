using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarPersonajeElegido : MonoBehaviour {



	 
	 public int NuneroDePersonajeSeleccionadoB;
	public GameObject prefabDruidaPersonaje1;
	public GameObject prefabCientificoPersonaje2;
	public GameObject prefabMafiosoPersonaje3;
	public GameObject prefabNaturalezaPersonaje4;
	public GameObject prefabMAgoPersonaje5;






	void Start () {
		InstanciarPersonajeElegidoFuncion ();




	}




	public void  	InstanciarPersonajeElegidoFuncion(){


	NuneroDePersonajeSeleccionadoB = cambiarPersonajeSeleccion.NuneroDePersonajeSeleccionado;


	if (NuneroDePersonajeSeleccionadoB == 1) {
		Instantiate(prefabDruidaPersonaje1, new Vector2(0,0), Quaternion.identity);

	}

	if (NuneroDePersonajeSeleccionadoB == 2) {
		Instantiate (prefabCientificoPersonaje2, new Vector2 (0, 0), Quaternion.identity);
	}


	if (NuneroDePersonajeSeleccionadoB == 3) {
		Instantiate (prefabMafiosoPersonaje3, new Vector2 (0, 0), Quaternion.identity);
	}

	if (NuneroDePersonajeSeleccionadoB == 4) {
		Instantiate (prefabNaturalezaPersonaje4, new Vector2 (0, 0), Quaternion.identity);
	}

	if (NuneroDePersonajeSeleccionadoB == 5) {
		Instantiate (prefabMAgoPersonaje5, new Vector2 (0, 0), Quaternion.identity);
	}


}
}
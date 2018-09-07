using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BotonRevivir : MonoBehaviour, IPointerClickHandler {



	public Text numeroDeRevivirDisponiblesText;
	static public int numeroDeRevivirDisponibles=2;

	public int NuneroDePersonajeSeleccionadoD;


	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	public GameObject prefab4;
	public GameObject prefab5;




	void Update(){

		numeroDeRevivirDisponiblesText.text = numeroDeRevivirDisponibles + " ";
	}


	public void OnPointerClick(PointerEventData pointerEventData){


	
		NuneroDePersonajeSeleccionadoD = cambiarPersonajeSeleccion.NuneroDePersonajeSeleccionado;


		if (numeroDeRevivirDisponibles > 0) {
			numeroDeRevivirDisponibles = numeroDeRevivirDisponibles - 1;


			if (NuneroDePersonajeSeleccionadoD == 1) {
				Instantiate(prefab1, new Vector2(0,0), Quaternion.identity);

			}

			if (NuneroDePersonajeSeleccionadoD == 2) {
				Instantiate (prefab2, new Vector2 (0, 0), Quaternion.identity);
			}


			if (NuneroDePersonajeSeleccionadoD == 3) {
				Instantiate (prefab3, new Vector2 (0, 0), Quaternion.identity);
			}

			if (NuneroDePersonajeSeleccionadoD == 4) {
				Instantiate (prefab4, new Vector2 (0, 0), Quaternion.identity);
			}

			if (NuneroDePersonajeSeleccionadoD == 5) {
				Instantiate (prefab5, new Vector2 (0, 0), Quaternion.identity);
			}
	
		}




	}



}


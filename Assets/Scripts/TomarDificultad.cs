using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarDificultad : MonoBehaviour {



	public float dificultadTomada;


	void Start () {
		dificultadTomada = DificultadDeJuego.dificultadSeleccionada;
		
	}
	

}

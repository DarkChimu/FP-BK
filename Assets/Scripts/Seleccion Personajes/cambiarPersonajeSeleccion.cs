﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiarPersonajeSeleccion : MonoBehaviour {





  static public int NuneroDePersonajeSeleccionado;


	//FLECHAS DE SELECCION DE PERSONAJE
	public int  personajeSeleccionDerechaB;
	public int  personajeSeleccionIzquierdaB;


	//PERSONAJES 

	//PERSONAJE1
	public GameObject Personaje1;


	//PERSONAJE2
	public GameObject Personaje2;



	//PERSONAJE3
	public GameObject Personje3;



	//PERSONAJE4 
	public GameObject Personaje4;



	//PERSONAJE5
	public GameObject Personaje5;









	void Update(){


		personajeSeleccionDerechaB = FlechaDerechaClick.personajeSeleccionDerecha;
		personajeSeleccionIzquierdaB = FlechaIzquierdaClick.personajeSeleccionIzquierda;

		NuneroDePersonajeSeleccionado = personajeSeleccionDerechaB + personajeSeleccionIzquierdaB;




		if(NuneroDePersonajeSeleccionado == 6){
			NuneroDePersonajeSeleccionado = 1;
			
		}


		if(NuneroDePersonajeSeleccionado == 0){
			NuneroDePersonajeSeleccionado = 5;

		}









		//PERSONAJE1(DRUIDA)
		if (NuneroDePersonajeSeleccionado == 1) {
			Personaje1.SetActive (true);
		

		} else {
			Personaje1.SetActive (false);
		

		}




		//PERSONAJE2 (CIENTIFICO)
		if (NuneroDePersonajeSeleccionado == 2) {
			Personaje2.SetActive (true);

		} else {
			Personaje2.SetActive (false);

		}




		//PERSONAJE3 MAFIOSO
		if (NuneroDePersonajeSeleccionado == 3) {
			Personje3.SetActive (true);

		} else {
			Personje3.SetActive (false);
				
		}




		//PERSONAJE4 NATULAEZA
		if (NuneroDePersonajeSeleccionado == 4) {
			Personaje4.SetActive (true);

		} else {
			Personaje4.SetActive (false);

		}
			

		//PERSONAJE 5 MAGO
		if (NuneroDePersonajeSeleccionado == 5) {
			Personaje5.SetActive (true);
		
		} else {
			Personaje5.SetActive (false);
		
		}


	

		}

	}












	


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DificultadDeJuego : MonoBehaviour {




	public bool DificultadFacil=false;
	public bool DificultadNormal=true;
	public bool DificultadDificil=false;
	public bool DificultadMuyDificil=false;




	



		public 	void modoFacil () {
		DificultadFacil = true;
		DificultadNormal = false;
		DificultadDificil = false;
		DificultadMuyDificil = false;

		}

		public 	void ModoNormal(){
		DificultadNormal = true;
		DificultadFacil = false;
		DificultadDificil = false;
		DificultadMuyDificil = false;

		}

		public void ModoDificil (){
		DificultadDificil = true; 
		DificultadFacil = false;
		DificultadNormal = false;
		DificultadMuyDificil = false;

		}



		public void ModoMuyDificil(){
		DificultadMuyDificil = true;
		DificultadFacil = false;
		DificultadNormal = false;
		DificultadDificil = false;

		}



	}










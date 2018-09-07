using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPersonaje1Druida : MonoBehaviour {





	//STATS VISIBLES EN INTERFAZ DE JUGADOR1
	static public int vida1 = 350;
	static public int StaminaDisponible1=130;
	static public int mana1=170;
	static public int defensaBase1=35;
	static public int AtaqueBase1=27;
	static public float VelocidadAtaque1=0.3f;


	static public int escudo1=100;
	static public int ataqueMagico1=30;



	public  bool Personaje1ColisionandoConElEnemigo;








	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje1ColisionandoConElEnemigo = true;
		}
	}




		void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje1ColisionandoConElEnemigo = false;
		}
	}




		void Update(){
		
		if (Personaje1ColisionandoConElEnemigo == true) {
			vida1 = vida1-1;
		}



		if (vida1 < 0) {
			Destroy (this.gameObject);
			vida1 = 500;
		


		}


		}






	}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsMafiosoPersonaje3 : MonoBehaviour {







	//STATS VISIBLES EN INTERFAZ DE JUGADOR1
	static public int vida3 = 120;
	static public int mana3=90;
	static public int StaminaDisponible3=190;
	static public int escudo3=155;

	//STATS  NO VISIBLES EN INTERFAZ DE JUGADOR1
	static public int defensaBase3=20;
	static public int AtaqueBase3=35;
	static public int ataqueMagico3=15;
	static public float VelocidadAtaque3=0.3f;


	public bool Personaje3colisionandoConElEnemigo;





	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje3colisionandoConElEnemigo = true;
		}
	}




	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje3colisionandoConElEnemigo = false;
		}
	}




	void Update ()
	{

		if (Personaje3colisionandoConElEnemigo == true) {
			vida3 = vida3 - 1;
		}



		if (vida3 < 0) {
			Destroy (this.gameObject);
			vida3 = 120;



		}
	}
}

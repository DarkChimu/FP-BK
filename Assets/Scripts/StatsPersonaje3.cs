using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPersonaje3 : MonoBehaviour {








	static public int vida3 = 250;
	static public int StaminaDisponible3=70;
	static public int mana3=230;
	static public int defensaBase3=23;
	static public int AtaqueBase3=18;
	static public int ataqueMagico3=59;



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

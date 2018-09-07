using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsPersonaje2 : MonoBehaviour {







	static public int vida2 = 500;
	static public int StaminaDisponible2=200;
	static public int mana2=100;
	static public int defensaBase2=48;
	static public int AtaqueBase2=42;
	static public int ataqueMagico2=10;

	public bool Personaje2colisionandoConElEnemigo;





	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje2colisionandoConElEnemigo = true;
		}
	}




	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje2colisionandoConElEnemigo = false;
		}
	}




	void Update ()
	{

		if (Personaje2colisionandoConElEnemigo == true) {
			vida2 = vida2 - 1;
		}



		if (vida2 < 0) {
			Destroy (this.gameObject);
			vida2 = 200;



		}

	}
}

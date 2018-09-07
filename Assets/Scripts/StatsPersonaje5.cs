using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPersonaje5 : MonoBehaviour {





	static public int vida5 = 250;
	static public int StaminaDisponible5=50;
	static public int mana5=250;
	 static public int defensaBase5=20;
	 static public int AtaqueBase5=18;
	static  public int ataqueMagico5=62;





	public bool Personaje5colisionandoConElEnemigo;





	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje5colisionandoConElEnemigo = true;
		}
	}




	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje5colisionandoConElEnemigo = false;
		}
	}




	void Update ()
	{

		if (Personaje5colisionandoConElEnemigo == true) {
			vida5 = vida5 - 1;
		}



		if (vida5 < 0) {
			Destroy (this.gameObject);
			vida5 = 125;



		}
	}
}


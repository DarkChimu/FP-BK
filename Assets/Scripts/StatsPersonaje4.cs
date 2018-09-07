using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPersonaje4 : MonoBehaviour {




	static public int vida4 = 500;
	static public int StaminaDisponible4=250;
	static public int mana4=50;
	 static public int defensaBase4=56;
	static public int AtaqueBase4=34;
	static  public int ataqueMagico4=10;




	public bool Personaje4colisionandoConElEnemigo;





	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje4colisionandoConElEnemigo = true;
		}
	}




	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			Personaje4colisionandoConElEnemigo = false;
		}
	}




	void Update ()
	{

		if (Personaje4colisionandoConElEnemigo == true) {
			vida4 = vida4 - 1;
		}



		if (vida4 < 0) {
			Destroy (this.gameObject);
			vida4 = 100;



		}
	}
}


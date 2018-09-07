using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPersonaje4Naturaleza : MonoBehaviour {




	//STATS VISIBLES EN INTERFAZ DE JUGADOR1
	static public int vida4 = 100;
	static public int mana4=120;
	static public int StaminaDisponible4=160;
	static public int escudo4=175;

	//STATS  NO VISIBLES EN INTERFAZ DE JUGADOR1
	 static public int defensaBase4=30;
	static public int AtaqueBase4=20;
	static  public int ataqueMagico4=20;
	static  public float VelocidadAtaque4=0.4f;



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


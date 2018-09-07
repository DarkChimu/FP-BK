using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPersonaje5Mago : MonoBehaviour {




	//STATS VISIBLES EN INTERFAZ DE JUGADOR1
	static public int vida5 = 125;
	static public int mana5=150;
	static public int StaminaDisponible5=130;
	static public int escudo5=150;

	//STATS  NO VISIBLES EN INTERFAZ DE JUGADOR1
	 static public int defensaBase5=25;
	 static public int AtaqueBase5=20;
	static  public int ataqueMagico5=25;
	static public float VelocidadAtaque5=0.4f;




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


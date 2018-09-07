using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsCientificoPersonaje2 : MonoBehaviour {







	//STATS VISIBLES EN INTERFAZ DE JUGADOR1
	static public int vida2 = 200;
	static public int mana2=170;
	static public int StaminaDisponible2=110;
	static public int escudo2=75;

	//STATS  NO VISIBLES EN INTERFAZ DE JUGADOR1
	static public int defensaBase2=25;
	static public int AtaqueBase2=20;
	static public int ataqueMagico2=25;
	static public float VelocidadAtaque2=0.4f;


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

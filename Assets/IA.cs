using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour {







	public Rigidbody2D enemigo;
	public GameObject Jugador;
	public GameObject Nido;
	public float DistanciaNidoEnemigoX;
	public float DistanciaNidoEnemigoY;



	//variables para medir la dififultad del juego
	public int numeroDeMazmorrasPasadas;
	public int DificultadDeJuego;
	public int VidaEnemigo;
	public int DamageEnemy;







	//ENEMIGO PERSEGUIR AL JUGADOR Y VOLVER AL NIDO SI SE ALEJA MUCHO


	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			PerseguirJugador ();
		}
	}




	void PerseguirJugador(){
		Jugador = GameObject.FindWithTag ("Player"); 
		enemigo.transform.position = Vector2.MoveTowards (enemigo.transform.position, Jugador.transform.position, 1 * Time.deltaTime);
		DistanciaNidoEnemigoX = Nido.transform.position.x - enemigo.transform.position.x;
		DistanciaNidoEnemigoY = Nido.transform.position.y - enemigo.transform.position.y;

		if ((DistanciaNidoEnemigoX > 5) || (DistanciaNidoEnemigoY > 5)) {
			VolverAlNido ();

		}
	}

		
	void VolverAlNido(){
		enemigo.transform.position = Vector2.MoveTowards (enemigo.transform.position,Nido.transform.position, 1*Time.deltaTime);
	}





	}







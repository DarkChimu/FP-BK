using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonajes : MonoBehaviour {



	public int NumeroPersonajeSeleccionadoC;
	public bool MoverArriba;
	public bool MoverAbajo;
	public bool MoverIzquierda;
	public bool MoverDerecha;



	public Rigidbody2D personaje1Rigidbody;
	private Animator animacionesPersonaje1;


	public Rigidbody2D personaje2Rigidbody;
	private Animator animacionesPersonaje2;


	public Rigidbody2D personaje3Rigidbody;
	private Rigidbody2D personaje4Rigidbody;

	public Rigidbody2D personaje5Rigidbody;	
	private Animator animacionesPersonaje5;







	void Start () {
		NumeroPersonajeSeleccionadoC = cambiarPersonajeSeleccion.NuneroDePersonajeSeleccionado;

	
	}




	void Update () {




		MoverAbajo = BotonAbajo.MoverPersonajeSeleccionadoAbajo;
		MoverArriba = BotonArriba.MoverPersonajeSeleccionadoArriba;
		MoverDerecha = BotonDerecha.MoverPersonajeSeleccionadoDerecha;
		MoverIzquierda = BotonIzquierda.MoverPersonajeSeleccionadoIzquierda;



		//LLAMAR FUNCIONES DE PERSONAJE 1
		if (NumeroPersonajeSeleccionadoC == 1) {
			MoverPersonaje1 ();

		}

		//LLAMAR FUNCIONES DE PERSONAJE 2
		if (NumeroPersonajeSeleccionadoC == 2) {
			MoverPersonaje2 ();
		}

		//LLAMAR FUNCIONES DE PERSONAJE 3
		if (NumeroPersonajeSeleccionadoC == 3) {
			MoverPersonaje3 ();
		}


		//LLAMAR FUNCIONES DE PERSONAJE 4
		if (NumeroPersonajeSeleccionadoC == 4) {
			MoverPersonaje4 ();
		}

	
		//LLAMAR FUNCIONES DE PERSONAJE 5
		if (NumeroPersonajeSeleccionadoC == 5) {
			MoverPersonaje5 ();
		}



	}






	public	void MoverPersonaje1(){

		if (GameObject.Find ("druidaPrefab(Clone)") != null) {
			
		
			
			personaje1Rigidbody = GameObject.Find ("druidaPrefab(Clone)").GetComponent<Rigidbody2D> ();
			animacionesPersonaje1 = personaje1Rigidbody.GetComponent<Animator> ();




			//SI ME MUEVO ARRIBA 
			if ((NumeroPersonajeSeleccionadoC == 1) && (MoverArriba == true)) {
				personaje1Rigidbody.position = Vector3.MoveTowards (personaje1Rigidbody.position, new Vector3 (personaje1Rigidbody.position.x, personaje1Rigidbody.position.y + 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO ABAJO 
			if ((NumeroPersonajeSeleccionadoC == 1) && (MoverAbajo == true)) {
				personaje1Rigidbody.position = Vector3.MoveTowards (personaje1Rigidbody.position, new Vector3 (personaje1Rigidbody.position.x, personaje1Rigidbody.position.y - 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 1) && (MoverIzquierda == true)) {
				personaje1Rigidbody.GetComponent<SpriteRenderer> ().flipX = true;
				personaje1Rigidbody.position = Vector3.MoveTowards (personaje1Rigidbody.position, new Vector3 (personaje1Rigidbody.position.x - 1, personaje1Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}

			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 1) && (MoverDerecha == true)) {
				personaje1Rigidbody.GetComponent<SpriteRenderer> ().flipX = false;
				personaje1Rigidbody.position = Vector3.MoveTowards (personaje1Rigidbody.position, new Vector3 (personaje1Rigidbody.position.x + 1, personaje1Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}




			if ((NumeroPersonajeSeleccionadoC == 1) && (MoverDerecha == true) || (MoverIzquierda == true)) {
				animacionesPersonaje1.Play ("WalkDuidaPersonaje1");
			} else {
				animacionesPersonaje1.Play ("IdleDruidaPersonaje1");
			}

	      

		}
	}









	public	void MoverPersonaje2(){

		if (GameObject.Find ("CientificoPersonaje2Prefab(Clone)") != null) {
			
			personaje2Rigidbody = GameObject.Find ("CientificoPersonaje2Prefab(Clone)").GetComponent<Rigidbody2D> ();
			animacionesPersonaje2 = personaje2Rigidbody.GetComponent<Animator> ();

			//SI ME MUEVO ARRIBA 
			if ((NumeroPersonajeSeleccionadoC == 2) && (MoverArriba == true)) {
				personaje2Rigidbody.position = Vector3.MoveTowards (personaje2Rigidbody.position, new Vector3 (personaje2Rigidbody.position.x, personaje2Rigidbody.position.y + 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO ABAJO 
			if ((NumeroPersonajeSeleccionadoC == 2) && (MoverAbajo == true)) {
				personaje2Rigidbody.position = Vector3.MoveTowards (personaje2Rigidbody.position, new Vector3 (personaje2Rigidbody.position.x, personaje2Rigidbody.position.y - 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 2) && (MoverIzquierda == true)) {
				personaje2Rigidbody.GetComponent<SpriteRenderer> ().flipX = true;
				personaje2Rigidbody.position = Vector3.MoveTowards (personaje2Rigidbody.position, new Vector3 (personaje2Rigidbody.position.x - 1, personaje2Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}

			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 2) && (MoverDerecha == true)) {
				personaje2Rigidbody.GetComponent<SpriteRenderer> ().flipX = false;
				personaje2Rigidbody.position = Vector3.MoveTowards (personaje2Rigidbody.position, new Vector3 (personaje2Rigidbody.position.x + 1, personaje2Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}


			if ((NumeroPersonajeSeleccionadoC == 2) && (MoverDerecha == true) || (MoverIzquierda == true)) {
				animacionesPersonaje2.Play ("WalkPersonaje2");
		
			} else {
				animacionesPersonaje2.Play ("idlePersonaje2");
			}
		}
	}








	public	void MoverPersonaje3(){

		if (GameObject.Find ("MafiosoPrefabPersonaje3(Clone)") != null) {
			
			personaje3Rigidbody = GameObject.Find ("MafiosoPrefabPersonaje3(Clone)").GetComponent<Rigidbody2D> ();


			//SI ME MUEVO ARRIBA 
			if ((NumeroPersonajeSeleccionadoC == 3) && (MoverArriba == true)) {
				personaje3Rigidbody.position = Vector3.MoveTowards (personaje3Rigidbody.position, new Vector3 (personaje3Rigidbody.position.x, personaje3Rigidbody.position.y + 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO ABAJO 
			if ((NumeroPersonajeSeleccionadoC == 3) && (MoverAbajo == true)) {
				personaje3Rigidbody.position = Vector3.MoveTowards (personaje3Rigidbody.position, new Vector3 (personaje3Rigidbody.position.x, personaje3Rigidbody.position.y - 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 3) && (MoverIzquierda == true)) {
				personaje3Rigidbody.GetComponent<SpriteRenderer> ().flipX = true;
				personaje3Rigidbody.position = Vector3.MoveTowards (personaje3Rigidbody.position, new Vector3 (personaje3Rigidbody.position.x - 1, personaje3Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}

			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 3) && (MoverDerecha == true)) {
				personaje3Rigidbody.GetComponent<SpriteRenderer> ().flipX = false;
				personaje3Rigidbody.position = Vector3.MoveTowards (personaje3Rigidbody.position, new Vector3 (personaje3Rigidbody.position.x + 1, personaje3Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}
		}
	}








	public	void MoverPersonaje4(){
		if (GameObject.Find ("PersonajeNatulaezaPrefab(Clone)") != null) {


			personaje4Rigidbody = GameObject.Find ("PersonajeNatulaezaPrefab(Clone)").GetComponent<Rigidbody2D> ();


			//SI ME MUEVO ARRIBA 
			if ((NumeroPersonajeSeleccionadoC == 4) && (MoverArriba == true)) {
				personaje4Rigidbody.position = Vector3.MoveTowards (personaje4Rigidbody.position, new Vector3 (personaje4Rigidbody.position.x, personaje4Rigidbody.position.y + 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO ABAJO 
			if ((NumeroPersonajeSeleccionadoC == 4) && (MoverAbajo == true)) {
				personaje4Rigidbody.position = Vector3.MoveTowards (personaje4Rigidbody.position, new Vector3 (personaje4Rigidbody.position.x, personaje4Rigidbody.position.y - 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 4) && (MoverIzquierda == true)) {
				personaje4Rigidbody.GetComponent<SpriteRenderer> ().flipX = true;
				personaje4Rigidbody.position = Vector3.MoveTowards (personaje4Rigidbody.position, new Vector3 (personaje4Rigidbody.position.x - 1, personaje4Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}

			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 4) && (MoverDerecha == true)) {
				personaje4Rigidbody.GetComponent<SpriteRenderer> ().flipX = false;
				personaje4Rigidbody.position = Vector3.MoveTowards (personaje4Rigidbody.position, new Vector3 (personaje4Rigidbody.position.x + 1, personaje4Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}
		}
	}









	public	void MoverPersonaje5(){
		if (GameObject.Find ("Barbarian_Mage(Clone)") != null) {

			personaje5Rigidbody = GameObject.Find ("Barbarian_Mage(Clone)").GetComponent<Rigidbody2D> ();
			animacionesPersonaje5 = personaje5Rigidbody.GetComponent<Animator> ();


			//SI ME MUEVO ARRIBA 
			if ((NumeroPersonajeSeleccionadoC == 5) && (MoverArriba == true)) {
				personaje5Rigidbody.position = Vector3.MoveTowards (personaje5Rigidbody.position, new Vector3 (personaje5Rigidbody.position.x, personaje5Rigidbody.position.y + 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO ABAJO 
			if ((NumeroPersonajeSeleccionadoC == 5) && (MoverAbajo == true)) {
				personaje5Rigidbody.position = Vector3.MoveTowards (personaje5Rigidbody.position, new Vector3 (personaje5Rigidbody.position.x, personaje5Rigidbody.position.y - 1, 0), 10 * Time.deltaTime);
			}


			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 5) && (MoverIzquierda == true)) {
				personaje5Rigidbody.GetComponent<SpriteRenderer> ().flipX = true;
				personaje5Rigidbody.position = Vector3.MoveTowards (personaje5Rigidbody.position, new Vector3 (personaje5Rigidbody.position.x - 1, personaje5Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}

			//SI ME MUEVO IZQUIERDA  
			if ((NumeroPersonajeSeleccionadoC == 5) && (MoverDerecha == true)) {
				personaje5Rigidbody.GetComponent<SpriteRenderer> ().flipX = false;
				personaje5Rigidbody.position = Vector3.MoveTowards (personaje5Rigidbody.position, new Vector3 (personaje5Rigidbody.position.x + 1, personaje5Rigidbody.position.y, 0), 10 * Time.deltaTime);
			}

			if ((NumeroPersonajeSeleccionadoC == 5) && (MoverDerecha == true) || (MoverIzquierda == true)) {
				animacionesPersonaje5.Play ("WalkMage");
			} else {
				animacionesPersonaje5.Play ("IdleMago");
			}
		}
	}





	}



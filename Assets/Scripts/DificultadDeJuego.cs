using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DificultadDeJuego : MonoBehaviour {






	static public float dificultadSeleccionada=1.0f;








	//dificultad facil
	public void DificultadSeleccionada1(){
		dificultadSeleccionada = 0.6f;
		SceneManager.LoadScene ("EscenaMapaSupervivencia", LoadSceneMode.Single);

	}


	//dificultad normal
	public void DificultadSeleccionada2(){
		dificultadSeleccionada= 1f;
		SceneManager.LoadScene ("EscenaMapaSupervivencia", LoadSceneMode.Single);



	}


	//dificultad dificil
	public void DificultadSeleccionada3(){
		dificultadSeleccionada = 2f;
		SceneManager.LoadScene ("EscenaMapaSupervivencia", LoadSceneMode.Single);
	

	}


	//dificultad  muy dificil
	public void DificultadSeleccionada4(){
		dificultadSeleccionada= 2.5f;
		SceneManager.LoadScene ("EscenaMapaSupervivencia", LoadSceneMode.Single);

	}

	}










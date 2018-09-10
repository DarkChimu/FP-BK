using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Cargador : MonoBehaviour {

	public void VolverMenu(){
		SceneManager.LoadScene("EscenaMenu", LoadSceneMode.Single);
	}

	public void CerrarJuego(){
		Application.Quit();
		Debug.Log("Aplicaccion Cerrada");
	}


}

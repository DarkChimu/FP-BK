using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPausa : MonoBehaviour {


	public GameObject panelDePausa;


	public void PonerPausa(){
		panelDePausa.SetActive (true);
		Time.timeScale = 0;
	}


	public void QuitarPausa(){
		panelDePausa.SetActive (false);
		Time.timeScale = 1;
	}
}

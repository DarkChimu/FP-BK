using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamareroBar : MonoBehaviour {





	public GameObject CamareroHablar;
	public GameObject ConsumiblesParaComprar;


	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			CamareroHablar.SetActive (true);
		
		}
	}


	public void CerrarCamareroHablar(){
		CamareroHablar.SetActive (false);
	}


	public void ComprarConsumibles(){
		ConsumiblesParaComprar.SetActive (true);
	}


	public void CerrarConsumiblesAComprar(){
		ConsumiblesParaComprar.SetActive(false);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamareroBar : MonoBehaviour {




    public GameObject botonHablarCamarero;
	public GameObject CamareroHablar;
	public GameObject ConsumiblesParaComprar;




	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
            botonHablarCamarero.SetActive(true);
			
		
		}
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            botonHablarCamarero.SetActive(false);


        }
    }

    public void CamarreroHablar() {
        CamareroHablar.SetActive(true);
       
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

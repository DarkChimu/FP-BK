using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlechaIzquierdaClick :  MonoBehaviour, IPointerClickHandler{




	
	static public int personajeSeleccionIzquierda=0;



	public void OnPointerClick(PointerEventData pointerEventData){
		personajeSeleccionIzquierda = personajeSeleccionIzquierda - 1;
	}
}

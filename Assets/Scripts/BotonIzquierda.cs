using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BotonIzquierda : MonoBehaviour ,IPointerDownHandler,IPointerUpHandler {


	static public bool MoverPersonajeSeleccionadoIzquierda;

	public void OnPointerDown (PointerEventData eventData) {
		MoverPersonajeSeleccionadoIzquierda = true;
	}


	public void OnPointerUp (PointerEventData eventData) {
		MoverPersonajeSeleccionadoIzquierda = false;
	}
}

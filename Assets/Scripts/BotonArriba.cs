using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotonArriba : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

	static public bool MoverPersonajeSeleccionadoArriba;




	public void OnPointerDown (PointerEventData eventData) {
		MoverPersonajeSeleccionadoArriba = true;
	}


	public void OnPointerUp (PointerEventData eventData) {
		MoverPersonajeSeleccionadoArriba = false;
	}

}

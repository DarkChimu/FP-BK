using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BotonAbajo : MonoBehaviour ,IPointerDownHandler,IPointerUpHandler{


	static public bool MoverPersonajeSeleccionadoAbajo;

    void Start() {
        MoverPersonajeSeleccionadoAbajo = false;
    }

	public void OnPointerDown (PointerEventData eventData) {
		MoverPersonajeSeleccionadoAbajo = true;
	}


	public void OnPointerUp (PointerEventData eventData) {
		MoverPersonajeSeleccionadoAbajo = false;
	}
}

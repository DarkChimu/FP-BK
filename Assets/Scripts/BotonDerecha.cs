using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BotonDerecha : MonoBehaviour ,IPointerDownHandler,IPointerUpHandler {


	static public bool MoverPersonajeSeleccionadoDerecha;


    void Start()
    {
       MoverPersonajeSeleccionadoDerecha = false;
    }

    public void OnPointerDown (PointerEventData eventData) {
		MoverPersonajeSeleccionadoDerecha = true;
	}


	public void OnPointerUp (PointerEventData eventData) {
		MoverPersonajeSeleccionadoDerecha = false;
	}
}

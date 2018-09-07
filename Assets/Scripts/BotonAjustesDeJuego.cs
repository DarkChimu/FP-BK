using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BotonAjustesDeJuego :MonoBehaviour, IPointerClickHandler {



	public GameObject JuegoPreferencias;










	public void OnPointerClick (PointerEventData pointerEventData)
	{
		
		JuegoPreferencias.SetActive (true);


	}
}

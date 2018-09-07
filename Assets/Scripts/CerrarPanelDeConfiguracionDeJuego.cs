using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CerrarPanelDeConfiguracionDeJuego :MonoBehaviour, IPointerClickHandler {



	public GameObject JuegoPreferencias2;

	public void OnPointerClick (PointerEventData pointerEventData)
	{

		JuegoPreferencias2.SetActive (false);


	}
}

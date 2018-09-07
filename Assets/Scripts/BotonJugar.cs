using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour, IPointerClickHandler {


	public void OnPointerClick (PointerEventData pointerEventData)
	{
		SceneManager.LoadScene ("EscenaSeleccionPersonajes", LoadSceneMode.Single);
	}
}
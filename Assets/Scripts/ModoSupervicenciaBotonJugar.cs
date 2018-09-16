using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ModoSupervivenciaBotonJugar : MonoBehaviour, IPointerClickHandler {


	public void OnPointerClick (PointerEventData pointerEventData)
	{
		SceneManager.LoadScene ("SeleccionDeDificultad", LoadSceneMode.Single);
	}
}
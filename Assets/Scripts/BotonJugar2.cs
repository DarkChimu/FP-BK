using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BotonJugar2 : MonoBehaviour, IPointerClickHandler {




	Animator ControladorAnimacionesBotonHistoria;




	void Start () {
		ControladorAnimacionesBotonHistoria = GetComponent<Animator>();

	}



	public void OnPointerClick (PointerEventData pointerEventData)
	{

		ControladorAnimacionesBotonHistoria.Play("Pressed");
		StartCoroutine(ClickEnModoHistoria());


	}


	IEnumerator ClickEnModoHistoria()
	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene("EscenaSeleccionPersonajes2", LoadSceneMode.Single);

	}
}
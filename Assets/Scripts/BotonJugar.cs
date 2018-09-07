using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour, IPointerClickHandler {




	Animator AnimatorBotonSupervivencia;




	void Start () {
		AnimatorBotonSupervivencia = GetComponent<Animator>();

	}



	public void OnPointerClick (PointerEventData pointerEventData)
	{

		AnimatorBotonSupervivencia.Play("Pressed");
		StartCoroutine(ClickEnModoSupervivencia());


	}


	IEnumerator ClickEnModoSupervivencia()
	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene ("EscenaSeleccionPersonajes", LoadSceneMode.Single);
	}

}
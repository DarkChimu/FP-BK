using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class OKSeleccionarEstePersonaje : MonoBehaviour,IPointerClickHandler {


	public bool clickEnOk;



	public void OnPointerClick(PointerEventData pointerEventData){
		clickEnOk = true;
		SceneManager.LoadScene("EscenaMapaHistoria", LoadSceneMode.Single);
		
	}



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class IrAlosCreditos : MonoBehaviour, IPointerClickHandler {


	
	public void OnPointerClick(PointerEventData PointerEventData){
		SceneManager.LoadScene ("Escena Creditos", LoadSceneMode.Single);	
	}
}

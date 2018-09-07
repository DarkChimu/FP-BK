using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class  AbrirTienda :  MonoBehaviour, IPointerClickHandler{





	public void OnPointerClick(PointerEventData pointerEventData){
		SceneManager.LoadScene ("EscenaTienda", LoadSceneMode.Single);
	}
}











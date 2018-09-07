using System;
using UnityEngine;


namespace UnityStandardAssets.Utility{
	public class FollowTarget : MonoBehaviour{
		
		private Transform personajeElegido;
		public Camera Camara;
		public GameObject menuRevivir;



		private void LateUpdate()	{
			
			if (GameObject.FindWithTag ("Player") != null) {
				menuRevivir.SetActive (false);
				personajeElegido = GameObject.FindWithTag ("Player").transform; 
				Camara.transform.position = personajeElegido.transform.position + new Vector3 (0, 0, -1);	
			} else {
				menuRevivir.SetActive (true);

			}




	
				
			}
	}
	
}

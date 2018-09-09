using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtacarEnemigo : MonoBehaviour {




	public GameObject bala1;
	public GameObject bala2;
	public GameObject bala3;
	public GameObject bala4;
	public Rigidbody2D bala1R;
	public Rigidbody2D bala2R;
	public Rigidbody2D bala3R;
	public Rigidbody2D bala4R;








	void Start(){

			StartCoroutine (EmpezarRafaga ());
		}






	  IEnumerator EmpezarRafaga (){
		 
		ActivarBalas();
		AplicarVelocidadBalas ();
		yield return new WaitForSeconds(2);
		DesactivarBalas ();
		VolverBalas ();
		StartCoroutine (EmpezarRafaga ());

		}




	void ActivarBalas(){
		bala1.SetActive (true);
		bala2.SetActive (true);
		bala3.SetActive (true);
		bala4.SetActive (true);
	}

	void DesactivarBalas(){
		bala1.SetActive (false);
		bala2.SetActive (false);
		bala3.SetActive (false);
		bala4.SetActive (false);
	}

	void AplicarVelocidadBalas(){
		bala1R.velocity = new Vector2 (5, 0);
		bala2R.velocity = new Vector2 (5, 0);
		bala3R.velocity = new Vector2 (5, 0);
		bala4R.velocity = new Vector2 (5, 0);
	}

	void QuitarVelocidadBalas(){
		bala1R.velocity = new Vector2 (0, 0);
		bala2R.velocity = new Vector2 (0, 0);
		bala3R.velocity = new Vector2 (0, 0);
		bala4R.velocity = new Vector2 (0, 0);
	}

	void VolverBalas(){
		bala1.transform.position = new Vector2 (1,0);
		bala2.transform.position = new Vector2 (-1,0);
		bala3.transform.position = new Vector2 (0,1);
		bala4.transform.position = new Vector2 (0,-1);


	}


}

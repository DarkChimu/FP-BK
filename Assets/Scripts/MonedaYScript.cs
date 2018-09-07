using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaYScript : MonoBehaviour {



	static public int MonedasY;



	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Player") {
			MonedasY = MonedasY + 1;
			Destroy (this.gameObject);
		}
}




}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaTScrip : MonoBehaviour {



	static public int MonedasT;




	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Player") {
			MonedasT= MonedasT + 1;
			Destroy (this.gameObject);
		}
	}
}

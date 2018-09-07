using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedasRevivir : MonoBehaviour {




	public int monedasRevivirA;
	public Text numeroDeMonedasDeRevivirEnTienda;

	void Update () {
		monedasRevivirA = BotonRevivir.numeroDeRevivirDisponibles;
		numeroDeMonedasDeRevivirEnTienda.text = "Revivir " + monedasRevivirA;
	}
}

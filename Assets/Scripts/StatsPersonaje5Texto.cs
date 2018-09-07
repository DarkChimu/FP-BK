using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPersonaje5Texto : MonoBehaviour {


	public int vida5A ;
	public int mana5A;
	public int StaminaDisponible5A;


	public Text vidaPersonaje5Texto;
	public Text manaPersonaje5Texto;
	public Text StaminaPersonaje5Texto;




	void Update () {

		vida5A = StatsPersonaje5.vida5;
		mana5A = StatsPersonaje5.mana5;
		StaminaDisponible5A =StatsPersonaje5. StaminaDisponible5;

		vidaPersonaje5Texto.text = "vida " + vida5A;
		manaPersonaje5Texto.text = "mana " + mana5A;
		StaminaPersonaje5Texto.text = "Stamina " + StaminaDisponible5A;


	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class StatsPersonaje4Texto : MonoBehaviour {



	public int vida4A ;
	public int mana4A;
	public int StaminaDisponible4A;


	public Text vidaPersonaje4Texto;
	public Text manaPersonaje4Texto;
	public Text StaminaPersonaje4Texto;



	void Update () {

		vida4A = StatsPersonaje4.vida4;
		mana4A =StatsPersonaje4.mana4;
		StaminaDisponible4A = StatsPersonaje4. StaminaDisponible4;


		vidaPersonaje4Texto.text = "vida " + vida4A;
		manaPersonaje4Texto.text = "mana " + mana4A;
		StaminaPersonaje4Texto.text = "Stamina " + StaminaDisponible4A;


	}
}
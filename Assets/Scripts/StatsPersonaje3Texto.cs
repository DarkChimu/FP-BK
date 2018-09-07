using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPersonaje3Texto : MonoBehaviour {


	public int vida3A = 200;
	public int mana3A=170;
	public int StaminaDisponible3A=110;


	public Text vidaPersonaje3Texto;
	public Text manaPersonaje3Texto;
	public Text StaminaPersonaje3Texto;




	void Update () {

		vida3A = StatsPersonaje3.vida3;
		mana3A =StatsPersonaje3.mana3;
		StaminaDisponible3A = StatsPersonaje3. StaminaDisponible3;


		vidaPersonaje3Texto.text = "vida " + vida3A;
		manaPersonaje3Texto.text = "mana " + mana3A;
		StaminaPersonaje3Texto.text = "Stamina " + StaminaDisponible3A;


	}
}

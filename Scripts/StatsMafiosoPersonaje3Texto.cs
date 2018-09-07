using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsMafiosoPersonaje3Texto : MonoBehaviour {


	public int vida3A = 200;
	public int mana3A=170;
	public int StaminaDisponible3A=110;
	public int escudo3A=75;

	public Text vidaPersonaje3Texto;
	public Text manaPersonaje3Texto;
	public Text StaminaPersonaje3Texto;
	public Text escudoPersonaje3Texto;



	void Update () {

		vida3A = StatsMafiosoPersonaje3.vida3;
		mana3A =StatsMafiosoPersonaje3.mana3;
		StaminaDisponible3A = StatsMafiosoPersonaje3. StaminaDisponible3;
		escudo3A=StatsMafiosoPersonaje3.escudo3;

		vidaPersonaje3Texto.text = "vida " + vida3A;
		manaPersonaje3Texto.text = "mana " + mana3A;
		StaminaPersonaje3Texto.text = "Stamina " + StaminaDisponible3A;
		escudoPersonaje3Texto.text = "Escudo " + escudo3A; 

	}
}

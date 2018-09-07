using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoStatsPersonaje2 : MonoBehaviour {




	 public int vida2A = 200;
	 public int mana2A=170;
	 public int StaminaDisponible2A=110;
	 public int escudo2A=75;

	public Text vidaPersonaje2Texto;
	public Text manaPersonaje2Texto;
	public Text StaminaPersonaje2Texto;
	public Text escudoPersonaje2Texto;



	void Update () {

		vida2A = statsCientificoPersonaje2.vida2;
		mana2A = statsCientificoPersonaje2.mana2;
		StaminaDisponible2A = statsCientificoPersonaje2. StaminaDisponible2;
		escudo2A=statsCientificoPersonaje2.escudo2;

		vidaPersonaje2Texto.text = "vida " + vida2A;
		manaPersonaje2Texto.text = "mana " + mana2A;
		StaminaPersonaje2Texto.text = "Stamina " + StaminaDisponible2A;
		escudoPersonaje2Texto.text = "Escudo " + escudo2A; 

	}
}

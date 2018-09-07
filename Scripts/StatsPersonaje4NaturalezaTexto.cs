using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class StatsPersonaje4NaturalezaTexto : MonoBehaviour {



	public int vida4A ;
	public int mana4A;
	public int StaminaDisponible4A;
	public int escudo4A;

	public Text vidaPersonaje4Texto;
	public Text manaPersonaje4Texto;
	public Text StaminaPersonaje4Texto;
	public Text escudoPersonaje4Texto;



	void Update () {

		vida4A = StatsPersonaje4Naturaleza.vida4;
		mana4A =StatsPersonaje4Naturaleza.mana4;
		StaminaDisponible4A = StatsPersonaje4Naturaleza. StaminaDisponible4;
		escudo4A=StatsPersonaje4Naturaleza.escudo4;

		vidaPersonaje4Texto.text = "vida " + vida4A;
		manaPersonaje4Texto.text = "mana " + mana4A;
		StaminaPersonaje4Texto.text = "Stamina " + StaminaDisponible4A;
		escudoPersonaje4Texto.text = "Escudo " + escudo4A; 

	}
}
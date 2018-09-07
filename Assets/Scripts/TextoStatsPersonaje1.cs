using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoStatsPersonaje1 : MonoBehaviour {






	public int mana1A; 
	public int escudo1A;
	public int VidaPersonaje1A;
	public int StaminaPersonaje1A;

	public Text NumeroManaPersonaje1Text;
	public Text EscudoPersonaje1Text;
	public Text VidaPersonaje1Text;
	public Text StaminaPersonaje1Texto;





	void Update () {

			mana1A = StatsPersonaje1Druida.mana1;
			escudo1A = StatsPersonaje1Druida.escudo1;
			VidaPersonaje1A = StatsPersonaje1Druida.vida1;
			StaminaPersonaje1A = StatsPersonaje1Druida.StaminaDisponible1;
			NumeroManaPersonaje1Text.text = "Mana "+ mana1A;
			EscudoPersonaje1Text.text = "Escudo" + escudo1A;
			VidaPersonaje1Text.text="vida "+VidaPersonaje1A;
			StaminaPersonaje1Texto.text = "Stamina " + StaminaPersonaje1A;




	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MostrarStatsEnPantalla : MonoBehaviour {





	//STATS DE PERSONAJE 5  PARA MOSTRAR EN PANTALLA DE SELECCION DE PERSONAJES 
	public int vida5Mostrar ;
	public int mana5Mostrar;
	public int StaminaDisponible5Mostrar;
	public int escudo5Mostrar;
	public int defensaBase5Mostrar;
	public int AtaqueBase5Mostrar;
	public int ataqueMagico5Mostrar;
	public float VelocidadAtaque5Mostrar;

	public GameObject StatsPersonaje5EnPantalla;

	public Text Vida5Text;
	public Text Mana5Text;
	public Text Stamina5Text;
	public Text Escudo5Text;
	public Text DefensaBase5Text;
	public Text Ataque5Text;
	public Text AtaqueMagico5Text;
	public Text VelocidadAtaque5Text;









	//STATS DE PERSONAJE 4  PARA MOSTRAR EN PANTALLA DE SELECCION DE PERSONAJES 
	public int vida4Mostrar ;
	public int mana4Mostrar;
	public int StaminaDisponible4Mostrar;
	public int escudo4Mostrar;
	public int defensaBase4Mostrar;
	public int AtaqueBase4Mostrar;
	public int ataqueMagico4Mostrar;
	public float VelocidadAtaque4Mostrar;

	public GameObject StatsPersonaje4EnPantalla;

	public Text Vida4Text;
	public Text Mana4Text;
	public Text Stamina4Text;
	public Text Escudo4Text;
	public Text DefensaBase4Text;
	public Text Ataque4Text;
	public Text AtaqueMagico4Text;
	public Text VelocidadAtaque4Text;















	//STATS DE PERSONAJE 3  PARA MOSTRAR EN PANTALLA DE SELECCION DE PERSONAJES 
	public int vida3Mostrar ;
	public int mana3Mostrar;
	public int StaminaDisponible3Mostrar;
	public int escudo3Mostrar;
	public int defensaBase3Mostrar;
	public int AtaqueBase3Mostrar;
	public int ataqueMagico3Mostrar;
	public float VelocidadAtaque3Mostrar;

	public GameObject StatsPersonaje3EnPantalla;

	public Text Vida3Text;
	public Text Mana3Text;
	public Text Stamina3Text;
	public Text Escudo3Text;
	public Text DefensaBase3Text;
	public Text Ataque3Text;
	public Text AtaqueMagico3Text;
	public Text VelocidadAtaque3Text;











	//STATS DE PERSONAJE 2  PARA MOSTRAR EN PANTALLA DE SELECCION DE PERSONAJES 
	public int vida2Mostrar ;
	public int mana2Mostrar;
	public int StaminaDisponible2Mostrar;
	public int escudo2Mostrar;
	public int defensaBase2Mostrar;
	public int AtaqueBase2Mostrar;
	public int ataqueMagico2Mostrar;
	public float VelocidadAtaque2Mostrar;
	public GameObject StatsPersonaje2EnPantalla;


	public Text Vida2Text;
	public Text Mana2Text;
	public Text Stamina2Text;
	public Text Escudo2Text;
	public Text DefensaBase2Text;
	public Text Ataque2Text;
	public Text AtaqueMagico2Text;
	public Text VelocidadAtaque2Text;












	//STATS DE PERSONAJE 1  PARA MOSTRAR EN PANTALLA DE SELECCION DE PERSONAJES 
	 public int vida1Mostrar ;
	public int mana1Mostrar;
	 public int StaminaDisponible1Mostrar;
	public int escudo1Mostrar;
	public int defensaBase1Mostrar;
	public int AtaqueBase1Mostrar;
	public int ataqueMagico1Mostrar;
	public float VelocidadAtaque1Mostrar;

	public GameObject StatsPersonaje1EnPantalla;

	public Text Vida1Text;
	public Text Mana1Text;
	public Text Stamina1Text;
	public Text Escudo1Text;
	public Text DefensaBase1Text;
	public Text Ataque1Text;
	public Text AtaqueMagico1Text;
	public Text VelocidadAtaque1Text;









	public int numeroPersonajeSeleccionadoAA;







	void Update () {
		
		numeroPersonajeSeleccionadoAA = cambiarPersonajeSeleccion.NuneroDePersonajeSeleccionado;


		if (numeroPersonajeSeleccionadoAA == 1) {

			StatsPersonaje1EnPantalla.SetActive (true);

			vida1Mostrar = StatsPersonaje1Druida.vida1;
			mana1Mostrar = StatsPersonaje1Druida.mana1;
			StaminaDisponible1Mostrar = StatsPersonaje1Druida.StaminaDisponible1;
			escudo1Mostrar = StatsPersonaje1Druida.escudo1;
			defensaBase1Mostrar = StatsPersonaje1Druida.defensaBase1;
			AtaqueBase1Mostrar = StatsPersonaje1Druida.AtaqueBase1;
			ataqueMagico1Mostrar = StatsPersonaje1Druida.ataqueMagico1;
			VelocidadAtaque1Mostrar = StatsPersonaje1Druida.VelocidadAtaque1;


			Vida1Text.text = "vida " + vida1Mostrar;
			Mana1Text.text = "mana " + mana1Mostrar;
			Stamina1Text.text = "Stamina " + StaminaDisponible1Mostrar;
			Escudo1Text.text = "escudo " + escudo1Mostrar;
			DefensaBase1Text.text = "defensa " + defensaBase1Mostrar;
			Ataque1Text.text = "Ataque " + AtaqueBase1Mostrar;
			AtaqueMagico1Text.text = "Ataque Magico " + ataqueMagico1Mostrar;
			VelocidadAtaque1Text.text = "velocidad de ataque  " + VelocidadAtaque1Mostrar;



		} else {
			StatsPersonaje1EnPantalla.SetActive (false);
		}








		if (numeroPersonajeSeleccionadoAA == 2) {

			StatsPersonaje2EnPantalla.SetActive (true);

			vida2Mostrar = statsCientificoPersonaje2.vida2;
			mana2Mostrar = statsCientificoPersonaje2.mana2;
			StaminaDisponible2Mostrar = statsCientificoPersonaje2.StaminaDisponible2;
			escudo2Mostrar = statsCientificoPersonaje2.escudo2;
			defensaBase2Mostrar = statsCientificoPersonaje2.defensaBase2;
			AtaqueBase2Mostrar = statsCientificoPersonaje2. AtaqueBase2;
			ataqueMagico2Mostrar = statsCientificoPersonaje2.ataqueMagico2;
			VelocidadAtaque2Mostrar = statsCientificoPersonaje2.VelocidadAtaque2;


			Vida2Text.text = "vida " + vida2Mostrar;
			Mana2Text.text = "mana " + mana2Mostrar;
			Stamina2Text.text = "Stamina " + StaminaDisponible2Mostrar;
			Escudo2Text.text = "escudo " + escudo2Mostrar;
			DefensaBase2Text.text = "defensa " + defensaBase2Mostrar;
			Ataque2Text.text = "Ataque " + AtaqueBase2Mostrar;
			AtaqueMagico2Text.text = "Ataque Magico " + ataqueMagico2Mostrar;
			VelocidadAtaque2Text.text = "velocidad de ataque  " + VelocidadAtaque2Mostrar;



		} else {
			StatsPersonaje2EnPantalla.SetActive (false);
		}










		if (numeroPersonajeSeleccionadoAA == 3) {

			StatsPersonaje3EnPantalla.SetActive (true);

			vida3Mostrar = StatsMafiosoPersonaje3.vida3;
			mana3Mostrar = StatsMafiosoPersonaje3.mana3;
			StaminaDisponible3Mostrar = StatsMafiosoPersonaje3.StaminaDisponible3;
			escudo3Mostrar = StatsMafiosoPersonaje3.escudo3;
			defensaBase3Mostrar = StatsMafiosoPersonaje3.defensaBase3;
			AtaqueBase3Mostrar = StatsMafiosoPersonaje3. AtaqueBase3;
			ataqueMagico3Mostrar = StatsMafiosoPersonaje3.ataqueMagico3;
			VelocidadAtaque3Mostrar = StatsMafiosoPersonaje3.VelocidadAtaque3;


			Vida3Text.text = "vida " + vida3Mostrar;
			Mana3Text.text = "mana " + mana3Mostrar;
			Stamina3Text.text = "Stamina " + StaminaDisponible3Mostrar;
			Escudo3Text.text = "escudo " + escudo3Mostrar;
			DefensaBase3Text.text = "defensa " + defensaBase3Mostrar;
			Ataque3Text.text = "Ataque " + AtaqueBase3Mostrar;
			AtaqueMagico3Text.text = "Ataque Magico " + ataqueMagico3Mostrar;
			VelocidadAtaque3Text.text = "velocidad de ataque  " + VelocidadAtaque3Mostrar;



		} else {
			StatsPersonaje3EnPantalla.SetActive (false);
		}




	





		if (numeroPersonajeSeleccionadoAA == 4) {

			StatsPersonaje4EnPantalla.SetActive (true);

			vida4Mostrar = StatsPersonaje4Naturaleza.vida4;
			mana4Mostrar = StatsPersonaje4Naturaleza.mana4;
			StaminaDisponible4Mostrar =StatsPersonaje4Naturaleza.StaminaDisponible4;
			escudo4Mostrar = StatsPersonaje4Naturaleza.escudo4;
			defensaBase4Mostrar = StatsPersonaje4Naturaleza.defensaBase4;
			AtaqueBase4Mostrar = StatsPersonaje4Naturaleza. AtaqueBase4;
			ataqueMagico4Mostrar = StatsPersonaje4Naturaleza.ataqueMagico4;
			VelocidadAtaque4Mostrar = StatsPersonaje4Naturaleza.VelocidadAtaque4;


			Vida4Text.text = "vida " + vida4Mostrar;
			Mana4Text.text = "mana " + mana4Mostrar;
			Stamina4Text.text = "Stamina " + StaminaDisponible4Mostrar;
			Escudo4Text.text = "escudo " + escudo4Mostrar;
			DefensaBase4Text.text = "defensa " + defensaBase4Mostrar;
			Ataque4Text.text = "Ataque " + AtaqueBase4Mostrar;
			AtaqueMagico4Text.text = "Ataque Magico " + ataqueMagico4Mostrar;
			VelocidadAtaque4Text.text = "velocidad de ataque  " + VelocidadAtaque4Mostrar;



		} else {
			StatsPersonaje4EnPantalla.SetActive (false);
		}
	











		if (numeroPersonajeSeleccionadoAA == 5) {

			StatsPersonaje5EnPantalla.SetActive (true);

			vida5Mostrar = StatsPersonaje5Mago.vida5;
			mana5Mostrar = StatsPersonaje5Mago.mana5;
			StaminaDisponible5Mostrar =StatsPersonaje5Mago.StaminaDisponible5;
			escudo5Mostrar = StatsPersonaje5Mago.escudo5;
			defensaBase5Mostrar = StatsPersonaje5Mago.defensaBase5;
			AtaqueBase5Mostrar = StatsPersonaje5Mago. AtaqueBase5;
			ataqueMagico5Mostrar = StatsPersonaje5Mago.ataqueMagico5;
			VelocidadAtaque5Mostrar = StatsPersonaje5Mago.VelocidadAtaque5;


			Vida5Text.text = "vida " + vida5Mostrar;
			Mana5Text.text = "mana " + mana5Mostrar;
			Stamina5Text.text = "Stamina " + StaminaDisponible5Mostrar;
			Escudo5Text.text = "escudo " + escudo5Mostrar;
			DefensaBase5Text.text = "defensa " + defensaBase5Mostrar;
			Ataque5Text.text = "Ataque " + AtaqueBase5Mostrar;
			AtaqueMagico5Text.text = "Ataque Magico " + ataqueMagico5Mostrar;
			VelocidadAtaque5Text.text = "velocidad de ataque  " + VelocidadAtaque5Mostrar;



		} else {
			StatsPersonaje5EnPantalla.SetActive (false);
		}











	}
}

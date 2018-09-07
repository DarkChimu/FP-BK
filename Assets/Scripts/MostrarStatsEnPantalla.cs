using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MostrarStatsEnPantalla : MonoBehaviour {





	//STATS DE PERSONAJE 5  PARA MOSTRAR EN PANTALLA DE SELECCION DE PERSONAJES 
	public int vida5Mostrar ;
	public int mana5Mostrar;
	public int StaminaDisponible5Mostrar;
	public int defensaBase5Mostrar;
	public int AtaqueBase5Mostrar;
	public int ataqueMagico5Mostrar;
	public float VelocidadAtaque5Mostrar;

	public GameObject StatsPersonaje5EnPantalla;

	public Text Vida5Text;
	public Text Mana5Text;
	public Text Stamina5Text;
	public Text DefensaBase5Text;
	public Text Ataque5Text;
	public Text AtaqueMagico5Text;










	//STATS DE PERSONAJE 4  PARA MOSTRAR EN PANTALLA DE SELECCION DE PERSONAJES 
	public int vida4Mostrar ;
	public int mana4Mostrar;
	public int StaminaDisponible4Mostrar;
	public int defensaBase4Mostrar;
	public int AtaqueBase4Mostrar;
	public int ataqueMagico4Mostrar;


	public GameObject StatsPersonaje4EnPantalla;

	public Text Vida4Text;
	public Text Mana4Text;
	public Text Stamina4Text;
	public Text DefensaBase4Text;
	public Text Ataque4Text;
	public Text AtaqueMagico4Text;
















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
	public Text DefensaBase3Text;
	public Text Ataque3Text;
	public Text AtaqueMagico3Text;











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
	public Text DefensaBase2Text;
	public Text Ataque2Text;
	public Text AtaqueMagico2Text;













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
	public Text DefensaBase1Text;
	public Text Ataque1Text;
	public Text AtaqueMagico1Text;










	public int numeroPersonajeSeleccionadoAA;







	void Update () {
		
		numeroPersonajeSeleccionadoAA = cambiarPersonajeSeleccion.NuneroDePersonajeSeleccionado;


		if (numeroPersonajeSeleccionadoAA == 1) {

			StatsPersonaje1EnPantalla.SetActive (true);

			vida1Mostrar = StatsPersonaje1Druida.vida1;
			mana1Mostrar = StatsPersonaje1Druida.mana1;
			StaminaDisponible1Mostrar = StatsPersonaje1Druida.StaminaDisponible1;

			defensaBase1Mostrar = StatsPersonaje1Druida.defensaBase1;
			AtaqueBase1Mostrar = StatsPersonaje1Druida.AtaqueBase1;
			ataqueMagico1Mostrar = StatsPersonaje1Druida.ataqueMagico1;



			Vida1Text.text = "vida " + vida1Mostrar;
			Mana1Text.text = "mana " + mana1Mostrar;
			Stamina1Text.text = "Stamina " + StaminaDisponible1Mostrar;

			DefensaBase1Text.text = "defensa " + defensaBase1Mostrar;
			Ataque1Text.text = "Ataque " + AtaqueBase1Mostrar;
			AtaqueMagico1Text.text = "Ataque Magico " + ataqueMagico1Mostrar;



		} else {
			StatsPersonaje1EnPantalla.SetActive (false);
		}








		if (numeroPersonajeSeleccionadoAA == 2) {

			StatsPersonaje2EnPantalla.SetActive (true);

			vida2Mostrar = statsPersonaje2.vida2;
			mana2Mostrar = statsPersonaje2.mana2;
			StaminaDisponible2Mostrar = statsPersonaje2.StaminaDisponible2;
		
			defensaBase2Mostrar = statsPersonaje2.defensaBase2;
			AtaqueBase2Mostrar = statsPersonaje2. AtaqueBase2;
			ataqueMagico2Mostrar = statsPersonaje2.ataqueMagico2;



			Vida2Text.text = "vida " + vida2Mostrar;
			Mana2Text.text = "mana " + mana2Mostrar;
			Stamina2Text.text = "Stamina " + StaminaDisponible2Mostrar;
	
			DefensaBase2Text.text = "defensa " + defensaBase2Mostrar;
			Ataque2Text.text = "Ataque " + AtaqueBase2Mostrar;
			AtaqueMagico2Text.text = "Ataque Magico " + ataqueMagico2Mostrar;




		} else {
			StatsPersonaje2EnPantalla.SetActive (false);
		}










		if (numeroPersonajeSeleccionadoAA == 3) {

			StatsPersonaje3EnPantalla.SetActive (true);

			vida3Mostrar = StatsPersonaje3.vida3;
			mana3Mostrar = StatsPersonaje3.mana3;
			StaminaDisponible3Mostrar = StatsPersonaje3.StaminaDisponible3;

			defensaBase3Mostrar = StatsPersonaje3.defensaBase3;
			AtaqueBase3Mostrar = StatsPersonaje3. AtaqueBase3;
			ataqueMagico3Mostrar = StatsPersonaje3.ataqueMagico3;



			Vida3Text.text = "vida " + vida3Mostrar;
			Mana3Text.text = "mana " + mana3Mostrar;
			Stamina3Text.text = "Stamina " + StaminaDisponible3Mostrar;

			DefensaBase3Text.text = "defensa " + defensaBase3Mostrar;
			Ataque3Text.text = "Ataque " + AtaqueBase3Mostrar;
			AtaqueMagico3Text.text = "Ataque Magico " + ataqueMagico3Mostrar;




		} else {
			StatsPersonaje3EnPantalla.SetActive (false);
		}




	





		if (numeroPersonajeSeleccionadoAA == 4) {

			StatsPersonaje4EnPantalla.SetActive (true);

			vida4Mostrar = StatsPersonaje4.vida4;
			mana4Mostrar = StatsPersonaje4.mana4;
			StaminaDisponible4Mostrar =StatsPersonaje4.StaminaDisponible4;

			defensaBase4Mostrar = StatsPersonaje4.defensaBase4;
			AtaqueBase4Mostrar = StatsPersonaje4. AtaqueBase4;
			ataqueMagico4Mostrar = StatsPersonaje4.ataqueMagico4;
		


			Vida4Text.text = "vida " + vida4Mostrar;
			Mana4Text.text = "mana " + mana4Mostrar;
			Stamina4Text.text = "Stamina " + StaminaDisponible4Mostrar;
		
			DefensaBase4Text.text = "defensa " + defensaBase4Mostrar;
			Ataque4Text.text = "Ataque " + AtaqueBase4Mostrar;
			AtaqueMagico4Text.text = "Ataque Magico " + ataqueMagico4Mostrar;



		} else {
			StatsPersonaje4EnPantalla.SetActive (false);
		}
	











		if (numeroPersonajeSeleccionadoAA == 5) {

			StatsPersonaje5EnPantalla.SetActive (true);

			vida5Mostrar = StatsPersonaje5.vida5;
			mana5Mostrar = StatsPersonaje5.mana5;
			StaminaDisponible5Mostrar =StatsPersonaje5.StaminaDisponible5;

			defensaBase5Mostrar = StatsPersonaje5.defensaBase5;
			AtaqueBase5Mostrar = StatsPersonaje5. AtaqueBase5;
			ataqueMagico5Mostrar = StatsPersonaje5.ataqueMagico5;
		


			Vida5Text.text = "vida " + vida5Mostrar;
			Mana5Text.text = "mana " + mana5Mostrar;
			Stamina5Text.text = "Stamina " + StaminaDisponible5Mostrar;

			DefensaBase5Text.text = "defensa " + defensaBase5Mostrar;
			Ataque5Text.text = "Ataque " + AtaqueBase5Mostrar;
			AtaqueMagico5Text.text = "Ataque Magico " + ataqueMagico5Mostrar;




		} else {
			StatsPersonaje5EnPantalla.SetActive (false);
		}











	}
}

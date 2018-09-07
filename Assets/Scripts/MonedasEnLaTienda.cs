using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedasEnLaTienda : MonoBehaviour {



	public int monedasYDisponibles;
	public int monedasTDisponobles;

	public Text monedasYDisponiblesText;
	public Text MonedasTDisponiblesText;


	
	void Update(){
		monedasTDisponobles = MonedasEnInterfaz.MonedasTB;
		monedasYDisponibles=  MonedasEnInterfaz.MonedasYB;

		MonedasTDisponiblesText.text = monedasTDisponobles+"";
		monedasYDisponiblesText.text = monedasYDisponibles+"";
	}

}

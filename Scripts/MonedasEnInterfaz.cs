using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MonedasEnInterfaz : MonoBehaviour {



	static public int MonedasYB;
	public Text MonedasYTexto;

	static public int MonedasTB;
	public  Text MonedasTTexto; 




	void Start(){

	}




	void Update ()
	{
		
		MonedasYB = MonedaYScript.MonedasY;
		MonedasYTexto.text = MonedasYB + " ";


		MonedasTB = MonedaTScrip.MonedasT;
		MonedasTTexto.text = MonedasTB + " ";

	}

}

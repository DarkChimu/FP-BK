using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedasComunes : MonoBehaviour {



	 


	static	public int monedasComunesTotales;
	public Text MonedasConmunesTexto;


	//inventario de pociones consumibles
	static public int NumeroDeConsumibles1;
	static public int NumeroDeConsumibles2;
	static public int NumeroDeConsumibles3;
	static public int NumeroDeConsumibles4;
	static public int NumeroDeConsumibles5;
	static public int NumeroDeConsumibles6;
	static public int NumeroDeConsumibles7;
	static public int NumeroDeConsumibles8;
	static public int NumeroDeConsumibles9;
	static public int NumeroDeConsumibles10;
	static public int NumeroDeConsumibles11;
	static public int NumeroDeConsumibles12;
	static public int NumeroDeConsumibles13;
	static public int NumeroDeConsumibles14;
	static public int NumeroDeConsumibles15;
	static public int NumeroDeConsumibles16;
	static public int NumeroDeConsumibles17;
	static public int NumeroDeConsumibles18;
	static public int NumeroDeConsumibles19;
	static public int NumeroDeConsumibles20;




	void Update(){
		monedasComunesTotales=Botones.monedas;
		MonedasConmunesTexto.text = " " + monedasComunesTotales; 
		NumeroDeConsumibles1 = Botones.ConsumiblesTipo1;
		NumeroDeConsumibles2 = Botones.ConsumiblesTipo2;
		NumeroDeConsumibles3 = Botones.ConsumiblesTipo3;
		NumeroDeConsumibles4 = Botones.ConsumiblesTipo4;
		NumeroDeConsumibles5 = Botones.ConsumiblesTipo5;
		NumeroDeConsumibles6 = Botones.ConsumiblesTipo6;
		NumeroDeConsumibles7 = Botones.ConsumiblesTipo7;
		NumeroDeConsumibles8 = Botones.ConsumiblesTipo8;
		NumeroDeConsumibles9 = Botones.ConsumiblesTipo9;
		NumeroDeConsumibles10 = Botones.ConsumiblesTipo10;
		NumeroDeConsumibles11 = Botones.ConsumiblesTipo11;
		NumeroDeConsumibles12 = Botones.ConsumiblesTipo12;
		NumeroDeConsumibles13 = Botones.ConsumiblesTipo13;
		NumeroDeConsumibles14 = Botones.ConsumiblesTipo14;
		NumeroDeConsumibles15 = Botones.ConsumiblesTipo15;
		NumeroDeConsumibles16 = Botones.ConsumiblesTipo16;
		NumeroDeConsumibles17 = Botones.ConsumiblesTipo17;
		NumeroDeConsumibles18 = Botones.ConsumiblesTipo18;
		NumeroDeConsumibles19 = Botones.ConsumiblesTipo19;
		NumeroDeConsumibles20 = Botones.ConsumiblesTipo20;

	}

	}



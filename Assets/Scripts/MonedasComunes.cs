using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedasComunes : MonoBehaviour {


    static public int pocionesAmarillaRedondaEnEquipoB;
    static public int pocionesAzulClaro2EnEquipoB;
    static public int pocionesVerdeEnEquipoB;
    static public int pocionesAmarillaGrandeEnEquipoB;
    static public int pocionesAzulGrandeEnEquipoB;
    static public int pocionesRojaGrandeEnEquipoB;
    static public int pocionesAmarillaMiniEnEquipoB;
    static public int pocionesAzulMiniEnEquipoB;
    static public int pocionesRoasMiniEnEquipoB;
    static public int pocionesAmarillasEnEquipoB;
    static public int pocionesAzulOscuro2EnEquipoB;
    static public int pocionesRojas2EnEquipoB;
    static public int pocionesRosas2EnEquipoB;
    static public int pocionesNaranjasEnEquipoB;
    static public int pocionesAzulClaroEnEquipoB;
    static public int pocionesGrisesEnEquipoB;
    static public int pocionesAzulOscuroEnEquipoB;
    static public int  pocionesRojasEnEquipoB;
   static  public int pocionesMarronesEnEquipoB;
    static public int pocionesRosasEnEquipoB;

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


    //numero de pociones en mochila
    public Text numeroPosionesMarrones;
    public Text numeroPocionesRosas;
    public Text numeroPocionesRojas;
    public Text numeroPocionesAzulOscuro;
    public Text numeroPocionesGrises;
    public Text numeroPocionesAzulClaro;
    public Text numeroPocionesNaranjas;
    public Text numeroPocionesRosas2;
    public Text numeroPocionesRojas2;
    public Text numeroPocionesAzulOscuro2;
    public Text numeroPocionesAmarillas;
    public Text numeroPocionRojaMini;
    public Text numeroPocionAzulMini;
    public Text numeroPocionAmarillaMini;
    public Text numeroPocionGrandeRoja;
    public Text numeroPocionGrandeAzul;
    public Text numeroPocionGrandeAmarilla;
    public Text numeroPocionesVerdes;
    public Text numeroPocionesAzuClaro2;
    public Text numeroPocionesAmarillasRedondas;



    void Update(){
        pocionesAmarillaRedondaEnEquipoB = Botones.pocionesAmarillaRedondaEnEquipo;
        pocionesAzulClaro2EnEquipoB = Botones.pocionesAzulClaro2EnEquipo;
         pocionesVerdeEnEquipoB =Botones.pocionesVerdesEnEquipo;
        pocionesAmarillaGrandeEnEquipoB = Botones.pocionesAmarillasGrandeEquipo;
        pocionesAzulGrandeEnEquipoB = Botones.pocionesAzulGrandeEquipo;
       pocionesRojaGrandeEnEquipoB = Botones.pocionesRojaGrandeEquipo;
        pocionesAmarillaMiniEnEquipoB = Botones.pocionesAmarillaMiniEquipo;
        pocionesAzulMiniEnEquipoB = Botones.pocionesAzulMiniEquipo;
        pocionesRoasMiniEnEquipoB = Botones.pocionesRojaMiniEquipo;
        pocionesAmarillasEnEquipoB = Botones.pocionesAmarillasEquipo;
      pocionesAzulOscuro2EnEquipoB = Botones.pocionesAzulOscuro2Equipo;
        pocionesRojas2EnEquipoB = Botones.pocionesRojas2EnEquipo;
        pocionesRosas2EnEquipoB = Botones.pocionesRosas2enEquipo;
        pocionesNaranjasEnEquipoB = Botones.pocionesNaranjasEnEquipo;
        pocionesAzulClaroEnEquipoB = Botones.pocionesAzulClaroEnEquipo;
        pocionesGrisesEnEquipoB = Botones.pocionesGrisesEnEquipo;
        pocionesAzulOscuroEnEquipoB = Botones.pocionesAzulOscuroEquipadas;
       pocionesRojasEnEquipoB = Botones.PocionesRojasEnEquipo;
        pocionesRosasEnEquipoB = Botones.PocionesRosasEnEquipo;
        pocionesMarronesEnEquipoB = Botones.PocionesMarronesEnEquipo;
        monedasComunesTotales =Botones.monedas;
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

        numeroPosionesMarrones.text = " " + NumeroDeConsumibles9;
        numeroPocionesRosas.text = " " +  NumeroDeConsumibles10;
        numeroPocionesRojas.text = " " + NumeroDeConsumibles1;
        numeroPocionesAzulOscuro.text = " " + NumeroDeConsumibles15;
        numeroPocionesGrises.text = " " + NumeroDeConsumibles16;
        numeroPocionesAzulClaro.text = " " + NumeroDeConsumibles17;
        numeroPocionesNaranjas.text = " " + NumeroDeConsumibles6;
        numeroPocionesRosas2.text = " " + NumeroDeConsumibles2;
        numeroPocionesAzulOscuro2.text = " " + NumeroDeConsumibles4;
        numeroPocionesRojas2.text = " " + NumeroDeConsumibles3;
        numeroPocionesAmarillas.text = "" + NumeroDeConsumibles11;
        numeroPocionRojaMini.text = " " + NumeroDeConsumibles12;
        numeroPocionAzulMini.text = " " + NumeroDeConsumibles13;
        numeroPocionAmarillaMini.text = " " + NumeroDeConsumibles14;
        numeroPocionGrandeRoja.text = " " + NumeroDeConsumibles18;
        numeroPocionGrandeAzul.text = " " + NumeroDeConsumibles19;
        numeroPocionGrandeAmarilla.text = " " + NumeroDeConsumibles20;
        numeroPocionesVerdes.text = " " + NumeroDeConsumibles8;
       numeroPocionesAzuClaro2.text = " " + NumeroDeConsumibles5;
        numeroPocionesAmarillasRedondas.text = " " + NumeroDeConsumibles7;
            }

	}



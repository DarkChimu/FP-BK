using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{



    static public int monedas = 100;

    static public int ConsumiblesTipo1;
    static public int ConsumiblesTipo2;//pocion Rosas2
    static public int ConsumiblesTipo3;//pociones Rojas2
    static public int ConsumiblesTipo4;//pocion azul oscuro2
    static public int ConsumiblesTipo5;//pocion azul claro2
    static public int ConsumiblesTipo6;//pociones naranjas
    static public int ConsumiblesTipo7;//pocion amarilla redonda
    static public int ConsumiblesTipo8;//pociones verdes
    static public int ConsumiblesTipo9; //pocion marron
    static public int ConsumiblesTipo10;//pocion rosa
    static public int ConsumiblesTipo11;//pocion amarilla
    static public int ConsumiblesTipo12;//pocion roja mini
    static public int ConsumiblesTipo13;//pocion azul mini
    static public int ConsumiblesTipo14;//pocion amarilla mini
    static public int ConsumiblesTipo15;//pocion azul oscuro
    static public int ConsumiblesTipo16;//pocion gris
    static public int ConsumiblesTipo17;//pocion azul claro
    static public int ConsumiblesTipo18;//pocion roja grande
    static public int ConsumiblesTipo19;//pocion azul grande
    static public int ConsumiblesTipo20;//pocion amarilla grande



    public GameObject Mochila;


    //COMPROBAR POCIONES DIFERENTES EQUIPADAS
    public int ComprobarPocionesAmarillaRedondaEnEquipo;
    public int ComprobarPocionesAzulClaro2EnEquipo;
    public int ComprobarPocionesVerdesEnEquipo;
    public int ComprobarPocionesAmarilloGrandeEnEquipo;
    public int ComprobarPocionesAzulGrandeEnEquipo;
    public int ComprobarPocionesRojaGrandeEnEquipo;
    public int ComprobarPocionesAmarillaMiniEnEquipo;
    public int ComprobarPocionesAzulMiniEnEquipo;
    public int ComprobarPocionesRojaMiniEnEquipo;
    public int ComprobarPocionesAmarillasEnEquipo;
    public int ComprobarPocionesAzulOscuro2EnEquipo;
    public int ComprobarPocionesRojas2EnEquipo;
    public int ComprobarPocionesRosas2EnEquipo;
    public int ComprobarPocionesNaranjasEnEquipo;
    public int ComprobarPocionesAzulesClaroEnEquipo;
    public int ComprobarPocionesGrisesEnEquipo;
    public int ComprobarSiTieneEsteTipoDePocionAzulOscuro;
    public int ComprobarSiTieneEsteTipoDePocionRoja;
    public int ComprobarSiTieneEsteTipoDePocionEquipadaMarron;//0 sin equipar - 1 equipado
    public int ComprobarSitieneEsteTipoDePocionEquipadaRosa;
    public int TiposDePocionesDiferentes;




    //POCIONES AMARILLA REDONDA 
    static public int pocionesAmarillaRedondaEnEquipo;
    public Text pocionesAmarilaRedondaEnInterfazText;
    public GameObject PocionesAmarillaRedondaInterfaz;

    //POCIONES AZUL CLARO2
    static public int pocionesAzulClaro2EnEquipo;
    public Text pocionesAzulClaro2EnInterfazText;
    public GameObject PocionesAzulClaro2Interfaz;

    //POCIONES VERDES
    static public int pocionesVerdesEnEquipo;
    public Text pocionesVerdesEnInterfazText;
    public GameObject PocionesVerdesInterfaz;

    //POCIONES AMARILLAS   GRANDE
    static public int pocionesAmarillasGrandeEquipo;
    public Text pocionesAmarillasGrandeEnInterfazText;
    public GameObject PocionesAmarillasGrandeInterfaz;

    //POCIONES AZUL GRANDE
    static public int pocionesAzulGrandeEquipo;
    public Text pocionesAzulGrandeEnInterfazText;
    public GameObject PocionesAzulGrandeInterfaz;


    //POCIONES ROJA GRANDE
    static public int pocionesRojaGrandeEquipo;
    public Text pocionesRojaGrandeEnInterfazText;
    public GameObject PocionesRojaGrandeInterfaz;

    //POCIONES AMARILLA MINI
    static public int pocionesAmarillaMiniEquipo;
    public Text pocionesAmarillaMiniEnInterfazText;
    public GameObject PocionesAmarillaMiniInterfaz;

    //POCIONES AZUL MINI
    static public int pocionesAzulMiniEquipo;
    public Text pocionesAzulMiniEnInterfazText;
    public GameObject PocionesAzulMiniInterfaz;

    //POCIONES ROJA MINI
    static public int pocionesRojaMiniEquipo;
    public Text pocionesRojaMiniEnInterfazText;
    public GameObject PocionesRojaMiniInterfaz;


    //POCIONES AMARILLAS 
    static public int pocionesAmarillasEquipo;
    public Text pocionesAmarillasEnInterfazText;
    public GameObject PocionesAmarillasInterfaz;


    //POCIONES AZUL OSCURO2
    static public int pocionesAzulOscuro2Equipo;
    public Text pocionesAzulOscuro2EnInterfazText;
    public GameObject PocionesAzulOScuro2Interfaz;

    //POCIONES ROJAS2 EN EQUIPO
    static  public int pocionesRojas2EnEquipo;
    public Text pocionesRojas2EnInterfazText;
    public GameObject PocionesRojas2Interfaz;


    //POCIONES ROSAS2 EN EQUIPO
    static public int pocionesRosas2enEquipo;
    public Text pocionesRosas2EnInterfazText;
    public GameObject PocionesRosas2Interfaz;


    //POCIONES NARANJAS EN EQUIPO
    static public int pocionesNaranjasEnEquipo;
    public Text PocionesNaranjasEnEquipoText;
    public GameObject PocionesNaranjaEquipadasInterfaz;


    //POCIONES AZUL CLARO
    static public int pocionesAzulClaroEnEquipo;
    public GameObject pocionesAzulClaroEnInterfaz;
    public Text numeroPocionesAzulesClaritaEquipadasText;




    //POCIONES GRISES EN EQUIPO
    static public int pocionesGrisesEnEquipo;
    public Text pocionesGrisesEnEquipoText;
    public GameObject InterfazPocionesGrisesEquipadas;



    //POCIONES AZUL OSCURO EN QUIPO
    static public int pocionesAzulOscuroEquipadas;
    public Text numeroPocionesAzulOscuroEquipadasText;
    public GameObject InterfazEquipoPocionesAzulOscuro;



    //POCIONES ROJAS EN EQUIPO
    static public int PocionesRojasEnEquipo;
    public GameObject pocionesRojasEquipadasInterfaz;
    public Text pocionesRojasEnEquipoText;



    //POCIONES MARRONES  EN EQUIPO
    static public int PocionesMarronesEnEquipo;
    public GameObject pocionesMarronesEquipoInterfaz;
    public Text NumeroPocionesMarronesEnInterfaz;



    //POCIONES ROSAS EN EQUIPO
    static public int PocionesRosasEnEquipo;
    public GameObject pocionesRosasEquipoInterfaz;
    public Text pocionesRosasEnEquipoText;





    public void AbrirMochila()
    {
        Mochila.SetActive(true);
    }

    public void CerrarMochila()
    {
        Mochila.SetActive(false);
    }



    // FUNCIONES PARA COMPRAR OBJETOS 
    public void ComprarObjeto1()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 9)
        {
            monedas = monedas - 10;
            ConsumiblesTipo1 = ConsumiblesTipo1 + 1;
            print("comprado");

        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto2()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo2 = ConsumiblesTipo2 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto3()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo3 = ConsumiblesTipo3 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto4()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo4 = ConsumiblesTipo4 + 1;
            print("comprado");
        }
    }
    public void ComprarObjeto5()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo5 = ConsumiblesTipo5 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto6()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            ConsumiblesTipo6 = ConsumiblesTipo6 + 1;
            monedas = monedas - 5;
            print("comprado");

        }
    }
    public void ComprarObjeto7()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo7 = ConsumiblesTipo7 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto8()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo8 = ConsumiblesTipo8 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto9()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo9 = ConsumiblesTipo9 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto10()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo10 = ConsumiblesTipo10 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto11()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo11 = ConsumiblesTipo11 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto12()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo12 = ConsumiblesTipo12 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto13()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo13 = ConsumiblesTipo13 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto14()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo14 = ConsumiblesTipo14 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto15()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo15 = ConsumiblesTipo15 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto16()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo16 = ConsumiblesTipo16 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto17()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo17 = ConsumiblesTipo17 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto18()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo18 = ConsumiblesTipo18 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto19()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo19 = ConsumiblesTipo19 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }
    public void ComprarObjeto20()
    {
        monedas = MonedasComunes.monedasComunesTotales;
        if (monedas > 6)
        {
            monedas = monedas - 5;
            ConsumiblesTipo20 = ConsumiblesTipo20 + 1;
            print("comprado");
        }
        else
        {
            print("monedas comunes insuficientes");
        }
    }






    //EQUIPAR/UTILIZAR POCIONES MARRONES
    public void EquiparPocionesMarrones()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo9 > 0) && (PocionesMarronesEnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
            ((TiposDePocionesDiferentes == 3) && (ComprobarSiTieneEsteTipoDePocionEquipadaMarron == 1) && (PocionesMarronesEnEquipo < 3)))
        {

            ConsumiblesTipo9 = ConsumiblesTipo9 - 1;
            PocionesMarronesEnEquipo = PocionesMarronesEnEquipo + 1;

            ActualizarEquipadosEnInterfaz();
        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
    }
    public void UtilizarPocionMarron()
    {
        PocionesMarronesEnEquipo = MonedasComunes.pocionesMarronesEnEquipoB;
        PocionesMarronesEnEquipo = PocionesMarronesEnEquipo - 1;
        print(PocionesMarronesEnEquipo);
        ActualizarEquipadosEnInterfaz();

    }

    //EQUIPAR/UTILIZAR POCIONES ROSAS
    public void EquiparPocionesRosas()
    {

        ComprobarCuantasPocionesDiferentesTengoEquipadas();
        if (((ConsumiblesTipo10 > 0) && (PocionesRosasEnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarSitieneEsteTipoDePocionEquipadaRosa == 1) && (PocionesRosasEnEquipo < 3)))
        {


            ConsumiblesTipo10 = ConsumiblesTipo10 - 1;
            PocionesRosasEnEquipo = PocionesRosasEnEquipo + 1;


        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }
    public void UsarPocionesRosas()
    {
        PocionesRosasEnEquipo = MonedasComunes.pocionesRosasEnEquipoB;
        PocionesRosasEnEquipo = PocionesRosasEnEquipo - 1;
        print("pocion rosa usada");
        ActualizarEquipadosEnInterfaz();
    }

    //EQUIPAR/UTILIZAR POCIONES ROJAS
    public void EquiparPocionesRojas()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();
        if (((ConsumiblesTipo1 > 0) && (PocionesRojasEnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarSiTieneEsteTipoDePocionRoja == 1) && (PocionesRojasEnEquipo < 3)))
        {

            ConsumiblesTipo1 = ConsumiblesTipo1 - 1;
            PocionesRojasEnEquipo = PocionesRojasEnEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }
    public void UsarPocionesRojas()
    {
        PocionesRojasEnEquipo = MonedasComunes.pocionesRojasEnEquipoB;
        PocionesRojasEnEquipo = PocionesRojasEnEquipo - 1;
        print("pocion roja usada");
        ActualizarEquipadosEnInterfaz();
    }

    //EQUIPAR/UTILIZAR POCIONES AZUL OSCURO
    public void EquiparPocionAzulOscuro()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();
        if (((ConsumiblesTipo15 > 0) && (pocionesAzulOscuroEquipadas < 3) && (TiposDePocionesDiferentes < 3)) ||
         ((TiposDePocionesDiferentes == 3) && (ComprobarSiTieneEsteTipoDePocionAzulOscuro == 1) && (pocionesAzulOscuroEquipadas < 3)))
        {

            ConsumiblesTipo15 = ConsumiblesTipo15 - 1;
            pocionesAzulOscuroEquipadas = pocionesAzulOscuroEquipadas + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }
    public void UsarPocionAzulOscuro()
    {
        pocionesAzulOscuroEquipadas = MonedasComunes.pocionesAzulOscuroEnEquipoB;
        pocionesAzulOscuroEquipadas = pocionesAzulOscuroEquipadas - 1;
        print("pocion azul oscuro usada");
        ActualizarEquipadosEnInterfaz();
    }



    //EQUIPAR/UTILIZAR POCIONES GRISES
    public void EquiparPocionGris()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();
        if (((ConsumiblesTipo16 > 0) && (pocionesGrisesEnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
         ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesGrisesEnEquipo == 1) && (pocionesGrisesEnEquipo < 3)))
        {

            ConsumiblesTipo16 = ConsumiblesTipo16 - 1;
            pocionesGrisesEnEquipo = pocionesGrisesEnEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }
    public void UsarPocionGris()
    {
        pocionesGrisesEnEquipo = MonedasComunes.pocionesGrisesEnEquipoB;
        pocionesGrisesEnEquipo = pocionesGrisesEnEquipo - 1;
        print("pocion gris usada");
        ActualizarEquipadosEnInterfaz();
    }




    //EQUIPAR/UTILIZAR POCIONES AZUL CLARITO
    public void EquiparPocionAzulClarito()
    {

        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo17 > 0) && (pocionesAzulClaroEnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAzulesClaroEnEquipo == 1) && (pocionesAzulClaroEnEquipo < 3)))
        {

            ConsumiblesTipo17 = ConsumiblesTipo17 - 1;
            pocionesAzulClaroEnEquipo = pocionesAzulClaroEnEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }


    public void UsarPocionAzulClarito()
    {
        pocionesAzulClaroEnEquipo = MonedasComunes.pocionesAzulClaroEnEquipoB;
        pocionesAzulClaroEnEquipo = pocionesAzulClaroEnEquipo - 1;
        print("pocion azul claro usada");
        ActualizarEquipadosEnInterfaz();
    }







    //EQUIPAR/UTILIZAR POCIONES NARANJAS
    public void EquiparPocionNaranja()
    {

        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo6 > 0) && (pocionesNaranjasEnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesNaranjasEnEquipo == 1) && (pocionesNaranjasEnEquipo < 3)))
        {

            ConsumiblesTipo6 = ConsumiblesTipo6 - 1;
            pocionesNaranjasEnEquipo = pocionesNaranjasEnEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }



    public void UsarPocionNaranja()
    {
        pocionesNaranjasEnEquipo = MonedasComunes.pocionesNaranjasEnEquipoB;
        pocionesNaranjasEnEquipo = pocionesNaranjasEnEquipo - 1;
        print("pocion naranja usada");
        ActualizarEquipadosEnInterfaz();
    }



    public void EquiparPocionRosa2()
    {

        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo2 > 0) && (pocionesRosas2enEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesRosas2EnEquipo == 1) && (pocionesRosas2enEquipo < 3)))
        {

            ConsumiblesTipo2 = ConsumiblesTipo2 - 1;
            pocionesRosas2enEquipo = pocionesRosas2enEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }


    public void UsarPocionRosa2()
    {
        pocionesRosas2enEquipo = MonedasComunes.pocionesRosas2EnEquipoB;
        pocionesRosas2enEquipo = pocionesRosas2enEquipo - 1;
        print("pocion rosa2 usada");
        ActualizarEquipadosEnInterfaz();
    }





    //EQUIPAR/UTILIZAR POCIONES ROJAS2
 
    public void EquiparPocionRoja2()
    {

        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo3 > 0) && (pocionesRojas2EnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesRojas2EnEquipo == 1) && (pocionesRojas2EnEquipo < 3)))
        {

            ConsumiblesTipo3 = ConsumiblesTipo3 - 1;
          pocionesRojas2EnEquipo = pocionesRojas2EnEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }

    public void UsarPocionRoja2() {
       pocionesRojas2EnEquipo = MonedasComunes.pocionesRojas2EnEquipoB;
        pocionesRojas2EnEquipo = pocionesRojas2EnEquipo - 1;
        print("pocion roja2 usada");
        ActualizarEquipadosEnInterfaz();
    }


    //EQUIPAR/UTILIZAR POCIONES AZUL OSCURO2

    public void EquiparPocionAzulOscuro2() {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo4 > 0) && (pocionesAzulOscuro2Equipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAzulOscuro2EnEquipo == 1) && (pocionesAzulOscuro2Equipo < 3)))
        {

            ConsumiblesTipo4= ConsumiblesTipo4 - 1;
            pocionesAzulOscuro2Equipo = pocionesAzulOscuro2Equipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }


    public void UsarPocionAzulOscuro2()
    {
        pocionesAzulOscuro2Equipo = MonedasComunes.pocionesAzulOscuro2EnEquipoB;
        pocionesAzulOscuro2Equipo = pocionesAzulOscuro2Equipo - 1;
        print("pocion azul oscuro2 usada");
        ActualizarEquipadosEnInterfaz();
    }


    //POCION AMARILLA
    public void EquiparPocionAmarilla()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo11 > 0) && (pocionesAmarillasEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAmarillasEnEquipo == 1) && (pocionesAmarillasEquipo < 3)))
        {

            ConsumiblesTipo11 = ConsumiblesTipo11 - 1;
           pocionesAmarillasEquipo = pocionesAmarillasEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }



    public void UsarPocionesAmarillas()
    {
       pocionesAmarillasEquipo = MonedasComunes.pocionesAmarillasEnEquipoB;
       pocionesAmarillasEquipo= pocionesAmarillasEquipo - 1;
        print("pocion amarilla usada");
        ActualizarEquipadosEnInterfaz();
    }


    //POCIONES ROJAS MINI
    public void EquiparPocionRojaMini()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo12 > 0) && (pocionesRojaMiniEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesRojaMiniEnEquipo == 1) && (pocionesRojaMiniEquipo < 3)))
        {

            ConsumiblesTipo12 = ConsumiblesTipo12 - 1;
            pocionesRojaMiniEquipo = pocionesRojaMiniEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }

    public void UsarPocionesRojasMini()
    {
       pocionesRojaMiniEquipo = MonedasComunes.pocionesRoasMiniEnEquipoB;
    pocionesRojaMiniEquipo = pocionesRojaMiniEquipo - 1;
        print("pocion roja mini usada");
        ActualizarEquipadosEnInterfaz();
    }



    //EQUIPAR/UTILIZAR POCION AZUL MINI
    public void EquiparPocionAzulMini()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo13 > 0) && (pocionesAzulMiniEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAzulMiniEnEquipo == 1) && (pocionesAzulMiniEquipo < 3)))
        {

            ConsumiblesTipo13 = ConsumiblesTipo13 - 1;
            pocionesAzulMiniEquipo = pocionesAzulMiniEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }



    public void UsarPocionesAzulMini()
    {
        pocionesAzulMiniEquipo = MonedasComunes.pocionesAzulMiniEnEquipoB;
        pocionesAzulMiniEquipo = pocionesAzulMiniEquipo - 1;
        print("pocion azul mini usada");
        ActualizarEquipadosEnInterfaz();
    }

    //EQUIPAR/UTILIZAR POCION AMARILLA MINI
    public void EquiparPocionAmarillaMini()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo14 > 0) && (pocionesAmarillaMiniEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAmarillaMiniEnEquipo == 1) && (pocionesAmarillaMiniEquipo < 3)))
        {

            ConsumiblesTipo14 = ConsumiblesTipo14 - 1;
            pocionesAmarillaMiniEquipo = pocionesAmarillaMiniEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }


    public void UsarPocionesAmarillaMini()
    {
       pocionesAmarillaMiniEquipo = MonedasComunes.pocionesAmarillaMiniEnEquipoB;
        pocionesAmarillaMiniEquipo = pocionesAmarillaMiniEquipo - 1;
        print("pocion amarilla mini usada");
        ActualizarEquipadosEnInterfaz();
    }



    //EQUIPAR/UTILIZAR POCION ROJA GRANDE
    public void EquiparPocionRojaGrande()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo18 > 0) && (pocionesRojaGrandeEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesRojaGrandeEnEquipo == 1) && (pocionesRojaGrandeEquipo < 3)))
        {

            ConsumiblesTipo18 = ConsumiblesTipo18 - 1;
            pocionesRojaGrandeEquipo = pocionesRojaGrandeEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }


    public void UsarPocionesRojaGrande()
    {
        pocionesRojaGrandeEquipo = MonedasComunes.pocionesRojaGrandeEnEquipoB;
        pocionesRojaGrandeEquipo = pocionesRojaGrandeEquipo - 1;
        print("pocion roja grande usada");
        ActualizarEquipadosEnInterfaz();
    }



    //EQUIPAR/UTILIZAR POCION AZUL GRANDE 
    public void EquiparPocionAzulGrande()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo19 > 0) && (pocionesAzulGrandeEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAzulGrandeEnEquipo == 1) && (pocionesAzulGrandeEquipo < 3)))
        {

            ConsumiblesTipo19 = ConsumiblesTipo19 - 1;
            pocionesAzulGrandeEquipo = pocionesAzulGrandeEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }

    public void UsarPocionesAzulGrande()
    {
        pocionesAzulGrandeEquipo = MonedasComunes.pocionesAzulGrandeEnEquipoB;
        pocionesAzulGrandeEquipo = pocionesAzulGrandeEquipo - 1;
        print("pocion azul grande usada");
        ActualizarEquipadosEnInterfaz();
    }



    //EQUIPAR/UTILIZAR POCION GRANDE AMARILLA 
    public void EquiparPocionAmarillaGrande()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo20 > 0) && (pocionesAmarillasGrandeEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAmarilloGrandeEnEquipo == 1) && (pocionesAmarillasGrandeEquipo < 3)))
        {

            ConsumiblesTipo20 = ConsumiblesTipo20 - 1;
            pocionesAmarillasGrandeEquipo = pocionesAmarillasGrandeEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }

    public void UsarPocionesAmarillaGrande()
    {
       pocionesAmarillasGrandeEquipo = MonedasComunes.pocionesAmarillaGrandeEnEquipoB;
        pocionesAmarillasGrandeEquipo = pocionesAmarillasGrandeEquipo - 1;
        print("pocion amarilla grande usada");
        ActualizarEquipadosEnInterfaz();
    }




    //EQUIPAR/GASTAR POCIONES VERDES
    public void EquiparPocionesVerdes()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo8 > 0) && (pocionesVerdesEnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesVerdesEnEquipo == 1) && (pocionesVerdesEnEquipo < 3)))
        {

            ConsumiblesTipo8 = ConsumiblesTipo8 - 1;
          pocionesVerdesEnEquipo = pocionesVerdesEnEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }

    public void UsarPocionVerde()
    {
        pocionesVerdesEnEquipo = MonedasComunes.pocionesVerdeEnEquipoB;
        pocionesVerdesEnEquipo = pocionesVerdesEnEquipo - 1;
        print("pocion verde usada");
        ActualizarEquipadosEnInterfaz();
    }




    //POCION AZUL CLARO2
    public void EquiparPocionAzulClaro2()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo5 > 0) && (pocionesAzulClaro2EnEquipo < 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAzulClaro2EnEquipo == 1) && (pocionesAzulClaro2EnEquipo < 3)))
        {

            ConsumiblesTipo5 = ConsumiblesTipo5 - 1;
            pocionesAzulClaro2EnEquipo = pocionesAzulClaro2EnEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }


    public void UsarPocionAzulClaro2()
    {
        pocionesAzulClaro2EnEquipo = MonedasComunes.pocionesAzulClaro2EnEquipoB;
        pocionesAzulClaro2EnEquipo = pocionesAzulClaro2EnEquipo - 1;
        print("pocion  azul claro2 usada");
        ActualizarEquipadosEnInterfaz();
    }



    //POCION AMARILLA REDONDA
    public void EquiparPocionAmarillaRedonda()
    {
        ComprobarCuantasPocionesDiferentesTengoEquipadas();

        if (((ConsumiblesTipo7 > 0) && (pocionesAmarillaRedondaEnEquipo< 3) && (TiposDePocionesDiferentes < 3)) ||
           ((TiposDePocionesDiferentes == 3) && (ComprobarPocionesAmarillaRedondaEnEquipo == 1) && (pocionesAmarillaRedondaEnEquipo < 3)))
        {

            ConsumiblesTipo7 = ConsumiblesTipo7 - 1;
            pocionesAmarillaRedondaEnEquipo = pocionesAmarillaRedondaEnEquipo + 1;

        }
        else
        {
            print("Ya tienes equipados el maximo numero de tipos de pociones o ya tienes la cantidad maxima (3) de estas ");
        }
        ActualizarEquipadosEnInterfaz();
    }


    public void UsarPocionAmarillaRedonda()
    {
       pocionesAmarillaRedondaEnEquipo = MonedasComunes.pocionesAmarillaRedondaEnEquipoB;
        pocionesAmarillaRedondaEnEquipo = pocionesAmarillaRedondaEnEquipo - 1;
        print("pocion  amarilla redonda usada");
        ActualizarEquipadosEnInterfaz();
    }




    //ACTUALIZAR CANTIDAD DE ELEMENTOS EN EQUIPO
    void ActualizarEquipadosEnInterfaz()
    {

        if (PocionesMarronesEnEquipo > 0)
        {
            pocionesMarronesEquipoInterfaz.SetActive(true);
            NumeroPocionesMarronesEnInterfaz.text = " " + PocionesMarronesEnEquipo;

        }
        else
        {

            pocionesMarronesEquipoInterfaz.SetActive(false);
            NumeroPocionesMarronesEnInterfaz.text = " " + PocionesMarronesEnEquipo;
        }



        if (PocionesRosasEnEquipo > 0)
        {
            pocionesRosasEquipoInterfaz.SetActive(true);
            pocionesRosasEnEquipoText.text = PocionesRosasEnEquipo + " ";
        }
        else
        {
            pocionesRosasEquipoInterfaz.SetActive(false);
            pocionesRosasEnEquipoText.text = PocionesRosasEnEquipo + " ";
        }


        if (PocionesRojasEnEquipo > 0)
        {
            pocionesRojasEquipadasInterfaz.SetActive(true);
            pocionesRojasEnEquipoText.text = " " + PocionesRojasEnEquipo;

        }
        else
        {
            pocionesRojasEquipadasInterfaz.SetActive(false);
            pocionesRojasEnEquipoText.text = " " + PocionesRojasEnEquipo;
        }


        if (pocionesAzulOscuroEquipadas > 0)
        {
            InterfazEquipoPocionesAzulOscuro.SetActive(true);
            numeroPocionesAzulOscuroEquipadasText.text = " " + pocionesAzulOscuroEquipadas;

        }
        else
        {
            InterfazEquipoPocionesAzulOscuro.SetActive(false);
            numeroPocionesAzulOscuroEquipadasText.text = " " + pocionesAzulOscuroEquipadas;
        }

        if (pocionesGrisesEnEquipo > 0)
        {
            InterfazPocionesGrisesEquipadas.SetActive(true);
            pocionesGrisesEnEquipoText.text = pocionesGrisesEnEquipo + " ";
        }
        else
        {
            InterfazPocionesGrisesEquipadas.SetActive(false);
            pocionesGrisesEnEquipoText.text = pocionesGrisesEnEquipo + " ";
        }


        if (pocionesAzulClaroEnEquipo > 0)
        {
            pocionesAzulClaroEnInterfaz.SetActive(true);
            numeroPocionesAzulesClaritaEquipadasText.text = " " + pocionesAzulClaroEnEquipo;
        }
        else
        {
            pocionesAzulClaroEnInterfaz.SetActive(false);
            numeroPocionesAzulesClaritaEquipadasText.text = " " + pocionesAzulClaroEnEquipo;
        }


        if (pocionesNaranjasEnEquipo > 0)
        {

            PocionesNaranjaEquipadasInterfaz.SetActive(true);
            PocionesNaranjasEnEquipoText.text = " " + pocionesNaranjasEnEquipo;
        }
        else
        {
            PocionesNaranjaEquipadasInterfaz.SetActive(false);
            PocionesNaranjasEnEquipoText.text = " " + pocionesNaranjasEnEquipo;
        }

        if (pocionesRosas2enEquipo > 0)
        {
            PocionesRosas2Interfaz.SetActive(true);
            pocionesRosas2EnInterfazText.text =pocionesRosas2enEquipo + " "; 
        }
        else {
            PocionesRosas2Interfaz.SetActive(false);
            pocionesRosas2EnInterfazText.text = pocionesRosas2enEquipo + " ";
        }

        if (pocionesRojas2EnEquipo > 0)
        {
            PocionesRojas2Interfaz.SetActive(true);
            pocionesRojas2EnInterfazText.text = " " + pocionesRojas2EnEquipo;
        }
        else {
            PocionesRojas2Interfaz.SetActive(false);
            pocionesRojas2EnInterfazText.text = " " + pocionesRojas2EnEquipo;
        }


        if (pocionesAzulOscuro2Equipo > 0)
        {
            PocionesAzulOScuro2Interfaz.SetActive(true);
          pocionesAzulOscuro2EnInterfazText.text = " " + pocionesAzulOscuro2Equipo;
        }
        else {
            PocionesAzulOScuro2Interfaz.SetActive(false);
            pocionesAzulOscuro2EnInterfazText.text = " " + pocionesAzulOscuro2Equipo;
        }

        if (pocionesAmarillasEquipo > 0)
        {
            PocionesAmarillasInterfaz.SetActive(true);
            pocionesAmarillasEnInterfazText.text = " " + pocionesAmarillasEquipo;
        }
        else {
            PocionesAmarillasInterfaz.SetActive(false);
            pocionesAmarillasEnInterfazText.text = " " + pocionesAmarillasEquipo;
        }

        if (pocionesRojaMiniEquipo > 0)
        {
            PocionesRojaMiniInterfaz.SetActive(true);
            pocionesRojaMiniEnInterfazText.text = " " + pocionesRojaMiniEquipo;
        }
        else {
            PocionesRojaMiniInterfaz.SetActive(false);
            pocionesRojaMiniEnInterfazText.text = " " + pocionesRojaMiniEquipo;
        }
        if (pocionesAzulMiniEquipo > 0)
        {
            PocionesAzulMiniInterfaz.SetActive(true);
            pocionesAzulMiniEnInterfazText.text = " " + pocionesAzulMiniEquipo;
        }
        else {

            PocionesAzulMiniInterfaz.SetActive(false);
            pocionesAzulMiniEnInterfazText.text = " " + pocionesAzulMiniEquipo;
        }


        if (pocionesAmarillaMiniEquipo > 0)
        {
            PocionesAmarillaMiniInterfaz.SetActive(true);
            pocionesAmarillaMiniEnInterfazText.text = pocionesAmarillaMiniEquipo + " ";

        }
        else {
            PocionesAmarillaMiniInterfaz.SetActive(false);
            pocionesAmarillaMiniEnInterfazText.text = pocionesAmarillaMiniEquipo + " ";
        }

        if (pocionesRojaGrandeEquipo > 0)
        {
            PocionesRojaGrandeInterfaz.SetActive(true);
            pocionesRojaGrandeEnInterfazText.text = " " + pocionesRojaGrandeEquipo;
        }
        else {
            PocionesRojaGrandeInterfaz.SetActive(false);
            pocionesRojaGrandeEnInterfazText.text = " " + pocionesRojaGrandeEquipo;
        }

        if (pocionesAzulGrandeEquipo > 0)
        {
            PocionesAzulGrandeInterfaz.SetActive(true);
          pocionesAzulGrandeEnInterfazText.text = " " + pocionesAzulGrandeEquipo;
        }
        else
        {
            PocionesAzulGrandeInterfaz.SetActive(false);
            pocionesAzulGrandeEnInterfazText.text = " " + pocionesAzulGrandeEquipo; ;
        }

        if (pocionesAmarillasGrandeEquipo > 0)
        {
            PocionesAmarillasGrandeInterfaz.SetActive(true);
            pocionesAmarillasGrandeEnInterfazText.text = " " + pocionesAmarillasGrandeEquipo;
        }
        else {
            PocionesAmarillasGrandeInterfaz.SetActive(false);
            pocionesAmarillasGrandeEnInterfazText.text = " " + pocionesAmarillasGrandeEquipo;
        }

        if (pocionesVerdesEnEquipo > 0)
        {
            PocionesVerdesInterfaz.SetActive(true);
            pocionesVerdesEnInterfazText.text = " " + pocionesVerdesEnEquipo;
        }
        else
        {
            PocionesVerdesInterfaz.SetActive(false);
            pocionesVerdesEnInterfazText.text = " " + pocionesVerdesEnEquipo;
        }

        if (pocionesAzulClaro2EnEquipo > 0)
        {
            PocionesAzulClaro2Interfaz.SetActive(true);
            pocionesAzulClaro2EnInterfazText.text = " " + pocionesAzulClaro2EnEquipo;
        }
        else {
            PocionesAzulClaro2Interfaz.SetActive(false);
            pocionesAzulClaro2EnInterfazText.text = " " + pocionesAzulClaro2EnEquipo;
        }

        if (pocionesAmarillaRedondaEnEquipo > 0)
        {
            PocionesAmarillaRedondaInterfaz.SetActive(true);
            pocionesAmarilaRedondaEnInterfazText.text = " " + pocionesAmarillaRedondaEnEquipo;
        }
        else {
            PocionesAmarillaRedondaInterfaz.SetActive(false);
            pocionesAmarilaRedondaEnInterfazText.text = " " + pocionesAmarillaRedondaEnEquipo;
        }

    }

  


    void ComprobarCuantasPocionesDiferentesTengoEquipadas()
    {

        if (PocionesMarronesEnEquipo > 0)
        {
            ComprobarSiTieneEsteTipoDePocionEquipadaMarron = 1;
        }
        else
        {
            ComprobarSiTieneEsteTipoDePocionEquipadaMarron = 0;
        }


        if (PocionesRosasEnEquipo > 0)
        {
            ComprobarSitieneEsteTipoDePocionEquipadaRosa = 1;
        }
        else
        {
            ComprobarSitieneEsteTipoDePocionEquipadaRosa = 0;
        }


        if (PocionesRojasEnEquipo > 0)
        {
            ComprobarSiTieneEsteTipoDePocionRoja = 1;
        }
        else
        {
            ComprobarSiTieneEsteTipoDePocionRoja = 0;
        }


        if (pocionesAzulOscuroEquipadas > 0)
        {
            ComprobarSiTieneEsteTipoDePocionAzulOscuro = 1;
        }
        else
        {
            ComprobarSiTieneEsteTipoDePocionAzulOscuro = 0;
        }


        if (pocionesGrisesEnEquipo > 0)
        {
            ComprobarPocionesGrisesEnEquipo = 1;
        }
        else
        {
            ComprobarPocionesGrisesEnEquipo = 0;
        }

        if (pocionesAzulClaroEnEquipo > 0)
        {
            ComprobarPocionesAzulesClaroEnEquipo = 1;
        }
        else
        {
            ComprobarPocionesAzulesClaroEnEquipo = 0;

        }

        if (pocionesNaranjasEnEquipo > 0)
        {
            ComprobarPocionesNaranjasEnEquipo = 1;
        }
        else
        {
            ComprobarPocionesNaranjasEnEquipo = 0;
        }

        if (pocionesRosas2enEquipo > 0)
        {
            ComprobarPocionesRosas2EnEquipo = 1;
        }
        else {
            ComprobarPocionesRosas2EnEquipo = 0;
        }

        if (pocionesRojas2EnEquipo > 0)
        {
            ComprobarPocionesRojas2EnEquipo = 1;
        }
        else {
            ComprobarPocionesRojas2EnEquipo = 0;
        }

        if (pocionesAzulOscuro2Equipo > 0)
        {
            ComprobarPocionesAzulOscuro2EnEquipo = 1;
        }
        else {
            ComprobarPocionesAzulOscuro2EnEquipo = 0;
        }


        if (pocionesAmarillasEquipo > 0)
        {
            ComprobarPocionesAmarillasEnEquipo = 1;
        }
        else {
            ComprobarPocionesAmarillasEnEquipo = 0;
        }


        if (pocionesRojaMiniEquipo > 0)
        {
            ComprobarPocionesRojaMiniEnEquipo = 1;
        }
        else {
            ComprobarPocionesRojaMiniEnEquipo = 0;
        }


        if (pocionesAzulMiniEquipo > 0)
        {
            ComprobarPocionesAzulMiniEnEquipo = 1;
        }
        else {
            ComprobarPocionesAzulMiniEnEquipo = 0;
        }

        if (pocionesAmarillaMiniEquipo > 0)
        {
            ComprobarPocionesAmarillaMiniEnEquipo = 1;
            pocionesAmarillaMiniEnInterfazText.text = " " + pocionesAmarillaMiniEquipo;
        }
        else {
            ComprobarPocionesAmarillaMiniEnEquipo = 0;
            pocionesAmarillaMiniEnInterfazText.text = " " + pocionesAmarillaMiniEquipo;
        }

        if (pocionesRojaGrandeEquipo > 0)
        {
            ComprobarPocionesRojaGrandeEnEquipo = 1;
           pocionesRojaGrandeEnInterfazText.text = " " + pocionesRojaGrandeEquipo;
        }
        else
        {
            ComprobarPocionesRojaGrandeEnEquipo = 0;
            pocionesRojaGrandeEnInterfazText.text = " " + pocionesRojaGrandeEquipo;
        }


        if (pocionesAzulGrandeEquipo > 0)
        {
            ComprobarPocionesAzulGrandeEnEquipo = 1;
           pocionesAzulGrandeEnInterfazText.text = " " + pocionesAzulGrandeEquipo;
        }
        else
        {
            ComprobarPocionesAzulGrandeEnEquipo = 0;
            pocionesAzulGrandeEnInterfazText.text = " " + pocionesAzulGrandeEquipo;
        }

        if (pocionesAmarillasGrandeEquipo > 0)
        {
            ComprobarPocionesAmarilloGrandeEnEquipo = 1;
            pocionesAmarillasGrandeEnInterfazText.text = " " + pocionesAmarillasGrandeEquipo;
        }
        else {
            ComprobarPocionesAmarilloGrandeEnEquipo = 0;
            pocionesAmarillasGrandeEnInterfazText.text = " " + pocionesAmarillasGrandeEquipo;
        }

        if (pocionesVerdesEnEquipo> 0)
        {
            ComprobarPocionesVerdesEnEquipo = 1;
            pocionesVerdesEnInterfazText.text = " " + pocionesVerdesEnEquipo;
        }
        else
        {
            ComprobarPocionesVerdesEnEquipo = 0;
            pocionesVerdesEnInterfazText.text = " " + pocionesVerdesEnEquipo;
        }

        if (pocionesAzulClaro2EnEquipo > 0)
        {
            ComprobarPocionesAzulClaro2EnEquipo = 1;
            pocionesAzulClaro2EnInterfazText.text = " " + pocionesAzulClaro2EnEquipo;
        }
        else {
            ComprobarPocionesAzulClaro2EnEquipo = 0;
            pocionesAzulClaro2EnInterfazText.text = " " + pocionesAzulClaro2EnEquipo;
        }

        if (pocionesAmarillaRedondaEnEquipo > 0) {
            ComprobarPocionesAmarillaRedondaEnEquipo = 1;
           pocionesAmarilaRedondaEnInterfazText.text = " " + pocionesAmarillaRedondaEnEquipo;
        }
        else
        {
            ComprobarPocionesAmarillaRedondaEnEquipo = 0;
            pocionesAmarilaRedondaEnInterfazText.text = " " + pocionesAmarillaRedondaEnEquipo;
        }


            TiposDePocionesDiferentes = ComprobarSiTieneEsteTipoDePocionEquipadaMarron +
            ComprobarSitieneEsteTipoDePocionEquipadaRosa + ComprobarSiTieneEsteTipoDePocionRoja +
            ComprobarSiTieneEsteTipoDePocionAzulOscuro + ComprobarPocionesGrisesEnEquipo + ComprobarPocionesAzulesClaroEnEquipo +
            ComprobarPocionesNaranjasEnEquipo+ComprobarPocionesRosas2EnEquipo+ComprobarPocionesRojas2EnEquipo+
            ComprobarPocionesAzulOscuro2EnEquipo+ComprobarPocionesAmarillasEnEquipo+ComprobarPocionesRojaMiniEnEquipo+
            ComprobarPocionesAzulMiniEnEquipo + ComprobarPocionesAmarillaMiniEnEquipo + ComprobarPocionesRojaGrandeEnEquipo+
            ComprobarPocionesAzulGrandeEnEquipo+ComprobarPocionesAmarilloGrandeEnEquipo+ComprobarPocionesVerdesEnEquipo+
            ComprobarPocionesAzulClaro2EnEquipo+ComprobarPocionesAmarillaRedondaEnEquipo;
    }



}














    
    




        

    











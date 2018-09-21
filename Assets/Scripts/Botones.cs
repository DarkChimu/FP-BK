using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{



    static public int monedas = 100;

    static public int ConsumiblesTipo1;
    static public int ConsumiblesTipo2;//pocion Rosas2
    static public int ConsumiblesTipo3;
    static public int ConsumiblesTipo4;
    static public int ConsumiblesTipo5;
    static public int ConsumiblesTipo6;//pociones naranjas
    static public int ConsumiblesTipo7;
    static public int ConsumiblesTipo8;
    static public int ConsumiblesTipo9; //pocion marron
    static public int ConsumiblesTipo10;//pocion rosa
    static public int ConsumiblesTipo11;
    static public int ConsumiblesTipo12;
    static public int ConsumiblesTipo13;
    static public int ConsumiblesTipo14;
    static public int ConsumiblesTipo15;//pocion azul oscuro
    static public int ConsumiblesTipo16;//pocion gris
    static public int ConsumiblesTipo17;//pocion azul claro
    static public int ConsumiblesTipo18;
    static public int ConsumiblesTipo19;
    static public int ConsumiblesTipo20;



    public GameObject Mochila;


    //COMPROBAR POCIONES DIFERENTES EQUIPADAS
    public int ComprobarPocionesRosas2EnEquipo;
    public int ComprobarPocionesNaranjasEnEquipo;
    public int ComprobarPocionesAzulesClaroEnEquipo;
    public int ComprobarPocionesGrisesEnEquipo;
    public int ComprobarSiTieneEsteTipoDePocionAzulOscuro;
    public int ComprobarSiTieneEsteTipoDePocionRoja;
    public int ComprobarSiTieneEsteTipoDePocionEquipadaMarron;//0 sin equipar - 1 equipado
    public int ComprobarSitieneEsteTipoDePocionEquipadaRosa;
    public int TiposDePocionesDiferentes;


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


        TiposDePocionesDiferentes = ComprobarSiTieneEsteTipoDePocionEquipadaMarron +
            ComprobarSitieneEsteTipoDePocionEquipadaRosa + ComprobarSiTieneEsteTipoDePocionRoja +
            ComprobarSiTieneEsteTipoDePocionAzulOscuro + ComprobarPocionesGrisesEnEquipo + ComprobarPocionesAzulesClaroEnEquipo +
            ComprobarPocionesNaranjasEnEquipo+ComprobarPocionesRosas2EnEquipo;
    }



}














    
    




        

    











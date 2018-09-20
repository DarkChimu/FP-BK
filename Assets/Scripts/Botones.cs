using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{



    static public int monedas = 100;

    static public int ConsumiblesTipo1;
    static public int ConsumiblesTipo2;
    static public int ConsumiblesTipo3;
    static public int ConsumiblesTipo4;
    static public int ConsumiblesTipo5;
    static public int ConsumiblesTipo6;
    static public int ConsumiblesTipo7;
    static public int ConsumiblesTipo8;
    static public int ConsumiblesTipo9; //pocion marron
    static public int ConsumiblesTipo10;//pocion rosa
    static public int ConsumiblesTipo11;
    static public int ConsumiblesTipo12;
    static public int ConsumiblesTipo13;
    static public int ConsumiblesTipo14;
    static public int ConsumiblesTipo15;
    static public int ConsumiblesTipo16;
    static public int ConsumiblesTipo17;
    static public int ConsumiblesTipo18;
    static public int ConsumiblesTipo19;
    static public int ConsumiblesTipo20;



    public GameObject Mochila;



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

    }



    //EQUIPAR/UTILIZAR POCIONES MARRONES


    public void EquiparPocionesMarrones()
    {

        if ((ConsumiblesTipo9 > 0) && (PocionesMarronesEnEquipo < 3))
        {

            ConsumiblesTipo9 = ConsumiblesTipo9 - 1;
            PocionesMarronesEnEquipo = PocionesMarronesEnEquipo + 1;

            ActualizarEquipadosEnInterfaz();
        }
    }




    public void UtilizarPocionMarron()
    {
        PocionesMarronesEnEquipo = MonedasComunes.pocionesMarronesEnEquipoB;
        PocionesMarronesEnEquipo = PocionesMarronesEnEquipo - 1;
        print(PocionesMarronesEnEquipo);
        ActualizarEquipadosEnInterfaz();

    }








    //POCIONES ROSAS


    public void EquiparPocionesRosas()
    {

        if ((ConsumiblesTipo10 > 0) && (PocionesRosasEnEquipo < 3))
        {


            ConsumiblesTipo10 = ConsumiblesTipo10 - 1;
            PocionesRosasEnEquipo = PocionesRosasEnEquipo + 1;


        }
        ActualizarEquipadosEnInterfaz();
    }




    public void UsarPocionesRosas()
    {
        PocionesRosasEnEquipo = MonedasComunes.pocionesRosasEnEquipoB;
        PocionesRosasEnEquipo = PocionesRosasEnEquipo - 1;
       print ( "pocion rosa usada");
        ActualizarEquipadosEnInterfaz();
    }





}


    
    




        

    











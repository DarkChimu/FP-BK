using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiarPersonajeSeleccion : MonoBehaviour {





  static public int NuneroDePersonajeSeleccionado;


	//FLECHAS DE SELECCION DE PERSONAJE
	public int  personajeSeleccionDerechaB;
	public int  personajeSeleccionIzquierdaB;


	//PERSONAJES 
	public GameObject Personaje1;
	public GameObject Personaje2;
	public GameObject Personje3;
	public GameObject Personaje4;
	public GameObject Personaje5;



    public GameObject flechaMas;
    public GameObject flechaMenos;






    void Update(){


		personajeSeleccionDerechaB = FlechaDerechaClick.personajeSeleccionDerecha;
		personajeSeleccionIzquierdaB = FlechaIzquierdaClick.personajeSeleccionIzquierda;

		NuneroDePersonajeSeleccionado = personajeSeleccionDerechaB + personajeSeleccionIzquierdaB;












        //PERSONAJE1
        if (NuneroDePersonajeSeleccionado == 1)
        {
            Personaje1.transform.localScale = new Vector3(2f, 2f, 0);
            flechaMenos.SetActive(false);


        }
        else {
            Personaje1.transform.localScale = new Vector3(1f, 1f, 0);
            flechaMenos.SetActive(true);
        }




        //PERSONAJE2 
        if (NuneroDePersonajeSeleccionado == 2)
        {
            Personaje2.transform.localScale = new Vector3(2f, 2f, 0);

        }
        else {
    Personaje2 .transform.localScale = new Vector3(1f, 1f, 0);
        }




        //PERSONAJE3
        if (NuneroDePersonajeSeleccionado == 3)
        {
            Personje3.transform.localScale = new Vector3(2f, 2f, 0);

        }
        else {
            Personje3.transform.localScale = new Vector3(1f, 1f, 0);
        }





		//PERSONAJE4 
		if (NuneroDePersonajeSeleccionado == 4) {
            Personaje4.transform.localScale = new Vector3(2f, 2f, 0);

        } else {
            Personaje4.transform.localScale = new Vector3(1f, 1f, 0);

        }
			

		//PERSONAJE 5 
		if (NuneroDePersonajeSeleccionado == 5) {
           Personaje5.transform.localScale = new Vector3(2f, 2f, 0);
            flechaMas.SetActive(false);

        } else {
            Personaje5.transform.localScale = new Vector3(1f, 1f, 0);
            flechaMas.SetActive(true);
        }


	
      

		}

	}












	


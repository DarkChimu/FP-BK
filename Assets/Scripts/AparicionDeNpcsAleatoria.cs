using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionDeNpcsAleatoria : MonoBehaviour {


    //numeros aleatorios
    public int NumeroNpcAleatorio1;
    public int NumeroNpcAleatorio2;
    public int NumeroNpcAleatorio3;

    //Npcs que pueden aparecer
    public GameObject Npc1;
    public GameObject Npc2;
    public GameObject Npc3;
    public GameObject Npc4;




    void Awake() {
        SacarNumerosAleatorios();
    }


    void SacarNumerosAleatorios() {

        //sacar aleatorio1
        NumeroNpcAleatorio1 = (Random.Range(1, 5));

        //sacar aleatorio2
        NumeroNpcAleatorio2 = (Random.Range(1, 5));

        //sacar aleatorio3
        NumeroNpcAleatorio3 = (Random.Range(1, 5));

        if ((NumeroNpcAleatorio1==NumeroNpcAleatorio2)||
            (NumeroNpcAleatorio1==NumeroNpcAleatorio3)||
           (NumeroNpcAleatorio2==NumeroNpcAleatorio3))
         
        {

            SacarNumerosAleatorios();
        }
        else {
            AprecerNpcs();
        }
     
       
    }


    void AprecerNpcs() {


        if ((NumeroNpcAleatorio1 == 1) || (NumeroNpcAleatorio2 == 1) || (NumeroNpcAleatorio3 == 1)) {
            Npc1.SetActive(true);
        }
        else{
            Npc1.SetActive(false);
        }


        if ((NumeroNpcAleatorio1 == 2) || (NumeroNpcAleatorio2 == 2) || (NumeroNpcAleatorio3 == 2))
        {
            Npc2.SetActive(true);
        }
        else
        {
            Npc2.SetActive(false);
        }

        if ((NumeroNpcAleatorio1 == 3) || (NumeroNpcAleatorio2 == 3) || (NumeroNpcAleatorio3 == 3))
        {
            Npc3.SetActive(true);
        }
        else
        {
            Npc3.SetActive(false);
        }

        if ((NumeroNpcAleatorio1 == 4) || (NumeroNpcAleatorio2 == 4) || (NumeroNpcAleatorio3 == 4))
        {
            Npc4.SetActive(true);
        }
        else
        {
            Npc4.SetActive(false);
        }

    }
	
	
}

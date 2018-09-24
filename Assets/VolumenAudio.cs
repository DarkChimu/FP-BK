using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumenAudio : MonoBehaviour {

    public AudioSource MusicaFondoMenu;
    public float VolumenMusica=1f;



	void Start () {
        MusicaFondoMenu = GameObject.Find("Main Camera").GetComponent<AudioSource>();
	}
	
	
	public void Update () {
        MusicaFondoMenu.volume = VolumenMusica;
     
	}

    public void CambiarVolumen(float volumenFinal) {
        VolumenMusica = volumenFinal; }
}

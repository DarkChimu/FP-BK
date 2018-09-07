using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuletaPersonajes : MonoBehaviour {

	//Lista De Personajes
	public GameObject[] Personajes;
	//Camara
	public Transform Camara;

	//variables Para La Adaptacion de la Ruleta
	private float Rueda,Grados,Angulo,MirarAngulo;
	private float X,Z;
	public float Distancia;

	//Variables Para que los personajes siempre Miren a la camara
	Vector3 Mirar;

	// Use this for initialization
	void Start () {

		//Adaptacion de la Ruleta dependiendo cuantos personajes agregen
		Angulo = 0;
		Rueda = 360;
		Grados = Rueda / Personajes.Length;

		for (int i = 0; i < Personajes.Length; i++) {
			
			Debug.Log (Angulo);
			X =  Mathf.Cos(Angulo * Mathf.Deg2Rad) * Distancia;
			Z =	Mathf.Sin(Angulo * Mathf.Deg2Rad) * Distancia;

			Angulo += Grados;

			Debug.Log ("Coseno "+ X + ", " + Z);
			Vector3 Posicion = new Vector3 (transform.position.x + X,
				  							transform.position.y,
				  							transform.position.z + Z);
			
				//Instantiate(Personajes[i], Posicion, Quaternion.identity,transform);
			Personajes[i].transform.position = Posicion;

		}


	}
	
	// Update is called once per frame
	void Update () {

		//Los Personajes Miran siempre a la Camara
		for (int i = 0; i < Personajes.Length; i++) {

			Mirar = Vector3.Normalize(Camara.position - Personajes [i].transform.position);
			MirarAngulo = Mathf.Atan2(Mirar.x, Mirar.y);
			Personajes[i].transform.rotation = new Quaternion(0, MirarAngulo,0, 0);
		}



	}



	public void Izquierda(){

		//transform.Rotate(Vector3.RotateTowards(new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z),new Vector3(transform.rotation.x,transform.rotation.y + Grados,transform.rotation.z),100 * Time.deltaTime,1));
		//transform.rotation = new Quaternion (0, transform.rotation.y + Grados, 0, 0);
		//transform.Rotate(Vector3.Lerp(Vector3.up * transform.rotation.y,Vector3.up * (transform.rotation.y + Grados) , 10 * Time.deltaTime));

		transform.Rotate(Vector3.up,Grados);


	}

	public void Derecha(){

	

		transform.Rotate(Vector3.up,-Grados);


	}
}
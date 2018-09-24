using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour {





    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")  {
            SceneManager.LoadScene("EscenaMapaHistoria", LoadSceneMode.Single);
          
        }
    }


    
}

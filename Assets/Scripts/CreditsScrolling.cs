using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsScrolling : MonoBehaviour
{
    private Vector2 destino;
    private Vector2 origen;

    private void Awake()
    {
        origen = new Vector2(transform.position.x, -300f);
        // Situar en posición inicial.
        transform.position = origen;
        destino = new Vector2(transform.position.x, 750f);
    }

    void Update()
    {
        if (transform.position.y >= destino.y)
        {
            transform.position = origen;
        }

        float speed = 40 * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, destino, speed);
    }
}

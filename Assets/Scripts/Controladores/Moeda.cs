using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public float tempoVida;
    public int valor;

    void Awake()
    {
        Destroy(gameObject, tempoVida);
    }

    public void AoColetar()
    {
        Debug.Log("Coletou Moeda!");
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        Destroy(gameObject, 2f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AoColetar();
        }
    }
}

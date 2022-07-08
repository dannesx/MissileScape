using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    public float tempoVida;

    void Awake()
    {
        Destroy(gameObject, tempoVida);
    }

    public void AoColetar()
    {
        Debug.Log("Escudo Coletado!");
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AoColetar();
        }
    }
}

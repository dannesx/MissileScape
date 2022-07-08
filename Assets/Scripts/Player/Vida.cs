using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public bool temEscudo = false;
    public GameObject escudo;

    void Update()
    {
        escudo.SetActive(temEscudo);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Escudo"))
        {
            temEscudo = true;
        }
        if(collision.gameObject.CompareTag("Missil"))
        {
            if(temEscudo)
            {
                temEscudo = false;
            }
        }
    }
}

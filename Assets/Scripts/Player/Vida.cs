using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public bool temEscudo = false;
    public GameObject escudo;
    public GerenciadorJogo Jogo;
    public GerenciadorPontos Pontos;
    public GerenciadorAudio Audio;

    void Update()
    {
        escudo.SetActive(temEscudo);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Escudo"))
        {
            Audio.somEscudo();
            temEscudo = true;
        }
        if(collision.gameObject.CompareTag("Missil"))
        {
            if(temEscudo)
            {
                temEscudo = false;
            }
            else {
                GameOver();
            }
        }

        if(collision.gameObject.CompareTag("Moeda"))
        {
            Audio.somMoeda();
            Pontos.GanharPontos(collision.gameObject.GetComponent<Moeda>().valor);
        }
    }

    void GameOver()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        DestroiRastro();
        Audio.somExlosaoNave();
        Jogo.GameOver();
    }

    void DestroiRastro(){
        TrailRenderer rastro = GetComponentInChildren<TrailRenderer>();
        rastro.enabled = false;
    }
}

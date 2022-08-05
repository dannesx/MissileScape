using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorAudio : MonoBehaviour
{
    public AudioSource motorNave, efeitosGerais;
    public AudioClip[] sfx;
    public GerenciadorJogo Jogo;

    void Update() 
    {
        motorNave.enabled = Jogo.jogoRodando;
    }

    public void somExlosaoMissil()
    {
        efeitosGerais.PlayOneShot(sfx[0]);
    }

    public void somExlosaoNave()
    {
        efeitosGerais.PlayOneShot(sfx[0]);
        motorNave.volume = 0f;
    }

    public void somMoeda()
    {
        efeitosGerais.PlayOneShot(sfx[1]);
    }

    public void somEscudo()
    {
        efeitosGerais.PlayOneShot(sfx[2]);
    }
}

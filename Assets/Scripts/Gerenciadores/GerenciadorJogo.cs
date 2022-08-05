using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GerenciadorJogo : MonoBehaviour
{
    public bool jogoRodando;
    public GerenciadorPontos Pontos;
    float tempo;

    void Update()
    {
        if(jogoRodando)
        {
            tempo += Time.deltaTime;
        }
    }

    public void PausarJogo()
    {
        Time.timeScale = 0f;
        jogoRodando = false;
    }

    public void VoltarAoJogo()
    {
        Time.timeScale = 1f;
        jogoRodando = true;
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }

    public void VoltarAoMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void GameOver()
    {
        Pontos.SetRecord();
        jogoRodando = false;
        Time.timeScale = 0f;
    }
}

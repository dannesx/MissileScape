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
    public GameObject painelPause, painelGameOver, HUD;
    public Text segundos, minutos;

    void Update()
    {
        if(jogoRodando)
        {
            tempo += Time.deltaTime;
            segundos.text = Mathf.RoundToInt(tempo % 60).ToString("00");
            minutos.text = Mathf.RoundToInt(tempo / 60).ToString("00");
        }
    }

    public void PausarJogo()
    {
        Time.timeScale = 0f;
        jogoRodando = false;
        painelPause.SetActive(true);
    }

    public void VoltarAoJogo()
    {
        Time.timeScale = 1f;
        jogoRodando = true;
        painelPause.SetActive(false);
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
        painelGameOver.SetActive(true);
    }
}

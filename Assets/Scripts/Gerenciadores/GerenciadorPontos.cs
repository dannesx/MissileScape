using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorPontos : MonoBehaviour
{
    public float pontos;
    public GerenciadorJogo Jogo;
    public Text txtPontos;

    void Update() 
    {
        if(Jogo.jogoRodando)
        {
            pontos += Time.deltaTime;
            txtPontos.text = Mathf.RoundToInt(pontos).ToString("0000");
        }
    }

    public void GanharPontos(int valor)
    {
        pontos += valor;
    }

    public void SetRecord()
    {
        if(!PlayerPrefs.HasKey("Record") || PlayerPrefs.GetInt("Record") < pontos)
        {
            PlayerPrefs.SetInt("Record", Mathf.RoundToInt(pontos));
        }
    }
}

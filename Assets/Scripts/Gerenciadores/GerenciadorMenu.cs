using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GerenciadorMenu : MonoBehaviour
{
    public GameObject painelRecord;
    public Text txtRecord;
    public AudioSource audio;

    void Start()
    {
        if(PlayerPrefs.HasKey("Record"))
        {
            painelRecord.SetActive(true);
            audio.Play();
            txtRecord.text = PlayerPrefs.GetInt("Record").ToString();
        }
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Jogo");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objeto;
    public float frequencia;
    float contador;

    // Update is called once per frame
    void Update()
    {
        if(contador < frequencia){
            contador += Time.deltaTime;
        } else {
            Spawn();
            contador = 0f;
        }
    }

    void Spawn(){
        Vector2 posicaoSpawn = Camera.main.ViewportToWorldPoint(new Vector2(Random.Range(-0.5f, 1.5f), Random.Range(-0.5f, 1.5f)));
        Instantiate(objeto, posicaoSpawn, Quaternion.identity);
    }
}

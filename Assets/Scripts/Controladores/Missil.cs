using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    Transform alvo;
    Rigidbody2D rb;
    TrailRenderer rastro;

    public float velocidade;
    public float rotacao;
    public float tempoVida;

    void Start()
    {
        alvo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        rastro = GetComponentInChildren<TrailRenderer>();
    }

    void FixedUpdate() {
        if(tempoVida > 0f){
            if(alvo != null){
                Vector2 direcao = (Vector2)alvo.position - rb.position;
                direcao.Normalize();
                float rot = Vector3.Cross(direcao, transform.up).z;
                rb.angularVelocity = -rot * rotacao;
                rb.velocity = transform.up * velocidade;
            }
        } else {
            DestroiMissil();
        }
        tempoVida -= Time.deltaTime;
    }

    void DestroiMissil(){
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        rastro.enabled = false;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Missil")){
            DestroiMissil();
        }

        if(collision.gameObject.CompareTag("Player")){
            DestroiMissil();
        }
    }
}

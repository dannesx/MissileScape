using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade;
    public float rotacao;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
       rb.velocity = transform.up * velocidade; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, -SimpleInput.GetAxis("Horizontal") * rotacao);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    //Diferença de velocidade entre a movimentação do player e do offset do céu
    //Usado para dar um efeito de profundidade
    public float parallax = 2f;

    //Componentes presentes no objeto Quad
    MeshRenderer mesh;
    Material texture;
    Vector2 offset;

    void Start()
    {
        //Acesso dos componentes do objeto
        mesh = GetComponent<MeshRenderer>();
        texture = mesh.material;
    }


    void Update()
    {
        //Configura o valor do offset para o que está no objeto atualmente
        offset = texture.mainTextureOffset;

        //Muda o valor do offest na horizontal e vertical conforme sua movimentação / pelo seu tamanho e / pelo parallax
        //Essas divisões servem para dar um efeito mais real: devido ao seu grande tamanho e sua profundidade, ele deve
        // ter um efeito de movimentação mais lento
        offset.x = transform.position.x / transform.localScale.x / parallax;
        offset.y = transform.position.y / transform.localScale.y / parallax;

        //Atualiza o valor do offeset da textura do objeto Quad
        texture.mainTextureOffset = offset;
    }
}

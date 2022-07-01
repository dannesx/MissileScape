using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSkyController : MonoBehaviour
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

        //Muda o valor do offset em y (vertical) adicionando a cada segundo seu valor/parallax
        offset.y +=  Time.deltaTime / parallax;

        //Atualiza o valor do offset da textura do objeto Quad
        texture.mainTextureOffset = offset;
    }
}

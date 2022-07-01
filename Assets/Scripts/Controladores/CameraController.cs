using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Referência do objeto player
    public GameObject player;

    //Limite da movimentação
    Vector3 movimentacao;

    void Start()
    {
        //Verifica se a referência do player foi feita com sucesso
        if (player != null)
        {
            //Diferença entre a sua posição inicial e do player
            movimentacao = transform.position - player.transform.position;
        }
    }

    void LateUpdate()
    {
        //Verifica se a referência do player foi feita com sucesso
        if(player != null)
        {        
            //Atualização da posição da camera conforme a do player + o offset pra manter a distância 
            transform.position = player.transform.position + movimentacao;
        }
    }
}

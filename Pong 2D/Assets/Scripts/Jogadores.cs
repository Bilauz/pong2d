using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{
    public float velocidadeDoJogador;

    public bool jogador1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (jogador1 == true)
        {
            MovimentoDoJogador1();
        }

    }

    public void MovimentoDoJogador1()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
}

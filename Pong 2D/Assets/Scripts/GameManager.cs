using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pontuacaoJogador1;

    public int pontuacaoJogador2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao1()
    {
        pontuacaoJogador1 += 1;
    }

    public void AumentarPontuacao2()
    {
        pontuacaoJogador2 += 1;
    }

}

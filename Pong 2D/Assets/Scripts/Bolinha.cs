using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinha : MonoBehaviour
{
    public float velocidadeDaBola;

    public Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig.velocity = new Vector2(velocidadeDaBola, velocidadeDaBola) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

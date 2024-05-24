using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float velocidade; 
    float xdir;
    Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }


    void FixedUpdate()
    {
        Vector2 velocidadeAtual = rigidbody2D.velocity;
        velocidadeAtual.x = velocidadeAtual.x + (xdir * velocidade);
        rigidbody2D.velocity = velocidadeAtual;
        
    }

    void OnMove(InputValue inputValue) {
        xdir = inputValue.Get<Vector2>().x;
        Debug.Log(xdir);
    }
}

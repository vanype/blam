using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private Vector2 moveVector;

    private float vec_x;
    private float vec_y;

    [SerializeField] private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveInput();
    }

    void MoveInput()
    {
        vec_x = Input.GetAxis("Horizontal");
        vec_y = Input.GetAxis("Vertical");
        moveVector = new Vector2(vec_x, vec_y);
        rb.velocity = moveVector * speed;
    }
}

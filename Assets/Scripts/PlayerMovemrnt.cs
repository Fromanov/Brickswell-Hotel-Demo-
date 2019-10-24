using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemrnt : MonoBehaviour
{
    public Animator animator;
    public float speed = 5f;   

    private Rigidbody2D rb2d;
    private Vector2 movement;
    private Vector2 mousePos;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = Input.mousePosition;

        animator.SetFloat("Speed", Mathf.Abs(movement.x));
        animator.SetBool("Attack", false);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Attack", true);
        }
    }
    
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb2d.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x); //* Mathf.Rad2Deg - 90f;
        rb2d.rotation = angle;
    }
}

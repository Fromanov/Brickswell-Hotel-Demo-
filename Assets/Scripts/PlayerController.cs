using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public Animator legsAnimator;
    public float speed = 5f;
    public GameObject mele;
    public string mask;
    public string weapon;

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

        mele.SetActive(false);

        
        animator.SetBool("Attack", false);
        legsAnimator.SetBool("isMoving", false);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Attack", true);
            //mele.SetActive(true);
			//Invoke(mele.SetActive(true), 1);
			//yield WaitForSeconds(2);
		}

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right mouse button down");

			//MeleSystem pickup;

            if (weapon == "Empty")
            {
				//this.weapon = pickup.gameObject.name;
				Debug.Log("Empty hands");
            }
           
        }

        if (Mathf.Abs(movement.x) != 0)
        {
            legsAnimator.SetBool("isMoving", true);
			animator.SetFloat("Speed", Mathf.Abs(movement.x));
		} 
		else if (Mathf.Abs(movement.y) != 0)
		{
			legsAnimator.SetBool("isMoving", true);
			animator.SetFloat("Speed", Mathf.Abs(movement.y));
		}
		else
		{
			animator.SetFloat("Speed", 0);
		}
    }
    
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);

        var mouseDir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(mouseDir.y, mouseDir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }   

    void PickUpWeapon(Collider2D collision)
    {
        switch (collision.name)
        {
            case "gaybar":
            Debug.Log("gaybar picked up");
            break;
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        
        Debug.Log("Here " + collision.collider.name);
    }
}

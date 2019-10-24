using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator animator;
    
    void Start()
    {
        animator.SetBool("isDead", false);
    }
    
    void Update()
    {
        
    }

    public void Dead()
    {
        animator.SetBool("isDead", true);
        Debug.Log("Enemy is dead");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator animator;

	private bool deadState = false;
    
    void Start()
    {
        animator.SetBool("isDead", false);
    }
    
    void Update()
    {
        
    }

    public void Dead()
    {
		if (!deadState)
		{
			animator.SetBool("isDead", true);
			Debug.Log("Enemy is dead");
			deadState = true;
		}
        
    }
}

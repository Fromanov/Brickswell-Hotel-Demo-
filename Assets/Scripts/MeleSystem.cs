using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {        
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy collided");
            EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
            enemy.Dead();
        }		
    }
}

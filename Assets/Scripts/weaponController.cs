using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour
{
    public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ItemRotator();        
    } 
    
    void ItemRotator()
    {
        float angleAmount = (Mathf.Cos(Time.time * rotationSpeed) * 180) / Mathf.PI * 0.1f;        
        angleAmount = Mathf.Clamp(angleAmount, -15, 15);
        this.transform.localRotation = Quaternion.Euler(0, 0, angleAmount);
        
        float scaleAmount = (Mathf.Sin(Time.time * rotationSpeed) * 180) / Mathf.PI * 0.01f;        
        scaleAmount = Mathf.Clamp(scaleAmount, 8, 9);
        Debug.Log("Scale " + scaleAmount);
        this.transform.localScale = new Vector3(scaleAmount, scaleAmount, 1);
    }
}

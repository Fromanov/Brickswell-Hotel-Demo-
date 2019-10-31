using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour
{
    public float rotationSpeed = 5f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        ItemRotator();        
    } 
    
    void ItemRotator()
    {
        float angleAmount = (Mathf.Cos(Time.time * rotationSpeed) * 180) / Mathf.PI * 0.1f;         //Item rotation     
        angleAmount = Mathf.Clamp(angleAmount, -15, 15);
        this.transform.localRotation = Quaternion.Euler(0, 0, angleAmount);
        
        float scaleAmount = (Mathf.Sin(Time.time * rotationSpeed) * 180) / Mathf.PI * 0.01f;        //Item scale
        scaleAmount = Mathf.Clamp(scaleAmount, 8, 9);        
        this.transform.localScale = new Vector3(scaleAmount, scaleAmount, 1);
    }
}

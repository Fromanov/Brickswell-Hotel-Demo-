using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void ButtonClick(GameObject obj)
    {

        string curText = obj.GetComponent<Button>().name;
        
        switch (curText)
        {
            case "ExitBtn": 
                Debug.Log("Exit works!");
                Application.Quit();
            break;

            case "StartBtn": 
                Debug.Log("Start works!");
                SceneManager.LoadScene("Testroom");
                break;
        }            
    }
}

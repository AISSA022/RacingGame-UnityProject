using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Finisharea1 : MonoBehaviour
{
    
    ////public GameObject wall;
    
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Car")
        {
            SceneManager.LoadScene("Finish");
        }

    }

    
}

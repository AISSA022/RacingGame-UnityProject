using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Health : MonoBehaviour
{
    public int health ;
    public GameObject healthn;
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "obstacles")
        {
            health = 100;
            health = health - 20;
        }
    }
   
    void Update()
    {
        healthn.GetComponent<TextMeshProUGUI>().text = health.ToString();
    }
}

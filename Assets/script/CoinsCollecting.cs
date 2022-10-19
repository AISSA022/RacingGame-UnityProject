using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinsCollecting : MonoBehaviour
{
    public int coins;
    public GameObject Coins;
    public AudioSource Collect;
    private void Start()
    {
        Coins.GetComponent<TextMeshProUGUI>().text = coins.ToString();
    }
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "coin")
        {
            Collect.Play();
            coins = coins + 1;
            col.gameObject.SetActive(false);
        }
        
    }

    void Update()
    {
        PlayerPrefs.SetInt("Coins",coins);
        Coins.GetComponent<TextMeshProUGUI>().text = coins.ToString();
    }
}

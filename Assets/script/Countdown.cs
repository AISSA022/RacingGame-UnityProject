using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource Ready;
    public AudioSource Count;
    public AudioSource Music;
    public AudioSource Engine;
    public GameObject LapTimer;
    
    void Start()
    {
        StartCoroutine(CountStart());
    }
    IEnumerator CountStart()
    {
        CountDown.GetComponent<TextMeshProUGUI>().text = "3";
        Count.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<TextMeshProUGUI>().text = "2";
        
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<TextMeshProUGUI>().text = "1";

        CountDown.SetActive(true);
        Music.Play();
        Engine.Play();
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
       
        LapTimer.SetActive(true);
        
    }
   
}
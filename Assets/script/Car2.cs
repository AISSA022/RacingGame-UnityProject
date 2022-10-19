using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;


    // Update is called once per frame
    void Update()
    {
        StartCoroutine(start1());
    }

    IEnumerator start1()
    {
       
            yield return new WaitForSeconds(3);
            transform.position = Vector3.MoveTowards(transform.position, target1.transform.position, 10f * Time.deltaTime);
            //transform.position = Vector3.MoveTowards(transform.position, target2.transform.position, 10f * Time.deltaTime);
        
    }


}


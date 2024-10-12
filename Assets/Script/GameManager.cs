using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update



    void Start()
    {
        StartCoroutine(startFire());

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator startFire()
    {

        yield return new WaitForSeconds(9);

        // start alarms

    }





}

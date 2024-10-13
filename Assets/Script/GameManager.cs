using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject alarm;
    [SerializeField] GameObject scream;


    [SerializeField] GameObject fire1Paper;




    [SerializeField] GameObject[] fires;

    [SerializeField] GameObject fireElectrics;




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

        yield return new WaitForSeconds(2);
        alarm.SetActive(true);


        yield return new WaitForSeconds(3);

        scream.SetActive(true);
        // start alarms

    }





}

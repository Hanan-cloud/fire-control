using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject alarm;
    [SerializeField] GameObject scream;


    [SerializeField] GameObject fire1Paper;




    [SerializeField] GameObject[] fires;
    [SerializeField] GameObject[] smallfires;

    [SerializeField] GameObject fireElectrics;

    public GameObject grapping;

    public GameObject powder;
    public GameObject water;
    
    public GameObject powderParticles;
    public GameObject waterParticles;



    public bool CanShuDownElec=false;
    public bool Canclosewindow=false;
    public bool CanShutDownFire2=false;


    public bool isWaterOn = false;

    XRIDefaultInputActions input;

    void Start()
    {

        StartCoroutine(startFire());


        input.XRILeftHand.FireOff.started += startWater;
        input.XRIRightHand.FireOff.started += startWater;


        input.XRILeftHand.FireOff.canceled+= closeWater;
        input.XRIRightHand.FireOff.canceled += closeWater;

    }

    private void closeWater(InputAction.CallbackContext obj)
    {
        isWaterOn = false;

    }

    private void startWater(InputAction.CallbackContext obj)
    {

        isWaterOn = true;


    }


    public void  GraapingSet(GameObject go)
    {
        grapping = go;
    }


    public void GraapingReSet()
    {
        grapping = null;
    }

    // Update is called once per frame
    void Update()
    {

        if (isWaterOn) { 

            if (grapping == powder)
            {

                powderParticles.SetActive(true);
                Debug.Log("powderOn");


            }
            else if (grapping == water)
            {


                waterParticles.SetActive(true);
                Debug.Log("waterOn");



            }
            else { return; }
        }
        else
        {
            waterParticles.SetActive(false);
            powderParticles.SetActive(false);
           // Debug.Log("both off");


        }
    }

        
    

   void OnEnable()
    {
        input = new XRIDefaultInputActions();
        input.XRILeftHand.Enable();
        input.XRIRightHand.Enable();
    }


    void OnDisable()
    {
        input.XRILeftHand.Disable();
        input.XRIRightHand.Disable();
    }
    IEnumerator startFire()
    {

        yield return new WaitForSeconds(2);
        alarm.SetActive(true);


        yield return new WaitForSeconds(3);

        scream.SetActive(true);
        // start alarms

    }


    public void startFireSequence()
    {

        StartCoroutine(fireSequence());
    }
    
    public void CloseFireSequence()
    {

        StartCoroutine(fireSequenceOff());
    }


    IEnumerator fireSequence()
    {
        

        for (int i = 0; i < fires.Length; i++)
        {
            yield return new WaitForSeconds(1);
            fires[i].SetActive(true);
        }

    }

    IEnumerator fireSequenceOff()
    {


        for (int i = 0; i < smallfires.Length; i++)
        {
            yield return new WaitForSeconds(1);
            smallfires[i].GetComponent<SmallFire>().SetFireDown=true;


            if(i==4)
            fireElectrics.SetActive(true);
        }


    }


}

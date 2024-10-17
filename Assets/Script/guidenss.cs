using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidenss : MonoBehaviour
{
    // Start is called before the first frame update

    float time = 0.5f;
    float tempTimer = 0;
    [SerializeField] GameObject next;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("co2"))
        {


            fire2.canScaleDown = true;
            tempTimer += Time.deltaTime*0.1f;
            if (tempTimer > time)
            {
                fire2.canScaleDown = false;

                next.SetActive(true);
                this.gameObject.SetActive(false);

            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("co2"))
        {

                fire2.canScaleDown = false;

            

        }
    }

}

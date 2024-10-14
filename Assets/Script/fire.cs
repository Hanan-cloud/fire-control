using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update

    ParticleSystem particle;
    private ParticleSystemRenderer psr;
    [SerializeField] private float minSize=0.1f;
    [SerializeField] private float speed;
    [SerializeField] UnityEvent action;
    public bool easlyOff = false;

    bool isEventStart;
    void Start()
    {
        isEventStart=false;
        particle = GetComponent<ParticleSystem>();
        psr = GetComponent<ParticleSystemRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        psr.minParticleSize = minSize;

        if(minSize < 0.4 && isEventStart==false)
        {
            action?.Invoke();
            isEventStart = true;
        }
        if (minSize < 0.1)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("water"))
        {
            minSize -= Time.deltaTime*speed;
        }
    }

}

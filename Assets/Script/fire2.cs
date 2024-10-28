using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class fire2 : MonoBehaviour
{
    ParticleSystem particle;
    private ParticleSystemRenderer psr;
    [SerializeField] private float minSize = 0.1f;
    [SerializeField] private float speed;
    [SerializeField] UnityEvent action;
    public bool easlyOff = false;

    [SerializeField] private string nameTag;
    public static bool canScaleDown= false;

    void Start()
    {
        canScaleDown = false;
        particle = GetComponent<ParticleSystem>();
        psr = GetComponent<ParticleSystemRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        psr.minParticleSize = minSize;

        if (canScaleDown)
        {
            minSize -= Time.deltaTime * speed;
        }
     
        if (minSize < 0.1)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }


    private void OnDisable()
    {
        action?.Invoke();

    }

}

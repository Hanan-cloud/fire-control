using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallFire : MonoBehaviour
{
    private ParticleSystem particle;
    private ParticleSystemRenderer psr;
    private double minSize;
    private float speed=0.1f;

    public bool SetFireDown { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        psr = GetComponent<ParticleSystemRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SetFireDown == false) return;


        minSize -= Time.deltaTime * speed;

        if (minSize < 0.1)
        {
            transform.parent.gameObject.SetActive(false);


        }
    }


}

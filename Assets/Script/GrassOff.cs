using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassOff : MonoBehaviour
{

    public bool isClosed=false;


    [SerializeField] Animator anim;
    void Start()
    {
        isClosed = false;

        anim = GetComponent<Animator>();
    }


    public void SetOff()
    {
        if (isClosed) return;
        anim.SetTrigger("Close");
        isClosed = true;

    }

   



}

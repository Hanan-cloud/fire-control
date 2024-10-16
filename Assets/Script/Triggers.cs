using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggers : MonoBehaviour
{
    [SerializeField] UnityEvent action;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            action?.Invoke();
            this.gameObject.SetActive(false);
        }
    }

}

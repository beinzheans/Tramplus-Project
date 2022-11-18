using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramDetection : MonoBehaviour
{
    public bool TramDetected;
    private void Start()
    {
        TramDetected = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tram"))
        {
            TramDetected = true;
        }
    }
}

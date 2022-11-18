using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteranceController : MonoBehaviour
{
    public GameObject EnteredPassenger;
    public GameObject Tram;
    private TramController tramControl;

    private void Start()
    {
        tramControl = Tram.GetComponent<TramController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pedestrain"))
        {
            tramControl.counter--;

            EnteredPassenger = other.gameObject;

            for (int i = 0; i < tramControl.counter; i++)
            {
                if (tramControl.Passengers[i] != null)
                {
                    continue;
                }

                tramControl.Passengers[i] = EnteredPassenger;
                break;
            }
        }
    }
}

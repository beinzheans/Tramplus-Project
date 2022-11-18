using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramController : MonoBehaviour
{
    public bool isInStation;
    public bool hasLeft;

    float timeInStation;
    float timeLeft;

    public int counter;

    private PedestrainBehaviour behaviour;

    public GameObject Enterance;
    private EnteranceController enteranceControl;
    public List<GameObject> Passengers = new List<GameObject>();

    private Rigidbody TramRB;
    private void Start()
    {
        isInStation = true;
        enteranceControl = Enterance.GetComponent<EnteranceController>();
        TramRB = gameObject.GetComponent<Rigidbody>();
        counter = 115;

        for (int i = 0; i < counter; i++)
        {
            Passengers.Add(null);
        }
    }

    private void Update()
    {
        if (isInStation)
        {
            if (timeInStation < 15.0f)
            {
                timeInStation += Time.deltaTime;
            }
            else
            {
                isInStation = false;
                timeInStation = 0.0f;
            }
        }
        else
        {
            if (timeLeft < 30.0f)
            {
                timeLeft += Time.deltaTime;
            }
            else
            {
                isInStation = true;
                timeLeft = 0.0f;
            }
        }

        if (gameObject.transform.position.x <= 50.0f)
        {
            hasLeft = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            hasLeft = false;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void FixedUpdate()
    {
        if (!isInStation && !hasLeft)
        {
            TramRB.MovePosition(new Vector3(gameObject.transform.position.x - 25.0f / 50.0f, 7.5f, 129.5f));
        }

        if (isInStation)
        {
            TramRB.MovePosition(new Vector3(102.25f, 7.5f, 129.5f));
        }
    }

}

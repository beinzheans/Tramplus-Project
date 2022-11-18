using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrainBehaviour : MonoBehaviour
{
    int ChanceToEnter;
    public float MoveSpeed;
    bool willEnterTram;
    private Rigidbody PedestrainRB;
    
    bool inPosition;

    bool isInTram;

    // Start is called before the first frame update
    void Start()
    {
        float rand;
        PedestrainRB = gameObject.GetComponent<Rigidbody>();
        ChanceToEnter = 14;
        MoveSpeed = 7.5f;

        rand = Random.Range(0, 1000); // Use range from 0 (inclusive) - 1000 (exclusive) to generate 1000 numbers. Only 14 out of the 1000 numbers will be available (<14) to make 1.4% chance

        if (rand < ChanceToEnter)
        {
            willEnterTram = true;
        }
        else
        {
            willEnterTram = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (!inPosition)
        {
            PedestrainRB.MovePosition(new Vector3(gameObject.transform.position.x - MoveSpeed / 50.0f, gameObject.transform.position.y, gameObject.transform.position.z));

        }
        else if (!isInTram)
        {
            PedestrainRB.MovePosition(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + MoveSpeed / 50.0f));
        }
    }

    private void Update()
    {

        if (willEnterTram)
        {
            if (gameObject.transform.position.x <= 107.5f)
            {
                inPosition = true;
            }
        }

        if (gameObject.transform.position.x <= 50.0f)
        {
            Destroy(gameObject);
        }

        if (gameObject.transform.position.z >= 127.0f)
        {
            isInTram = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

    }
}

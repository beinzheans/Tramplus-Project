using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class PedestrainSpawn : MonoBehaviour
{
    [Range(0, 5)]
    public float PeopleDensity;
    public GameObject Pedestrain;

    float TimeElapsed;
    public int numberOfPedestrains;

    GameObject newObject;


    // Update is called once per frame
    void Update()
    {

        if (TimeElapsed < 1.0f)
        {
            TimeElapsed += Time.deltaTime;
        }
        else
        {
            numberOfPedestrains = Mathf.RoundToInt(PeopleDensity * (gameObject.transform.lossyScale.z * gameObject.transform.lossyScale.x));

            for (int i = 0; i < numberOfPedestrains; i++)
            {
                newObject = Instantiate(Pedestrain,
                    new Vector3(gameObject.transform.position.x + Random.Range(-45.0f, 45.0f),
                                gameObject.transform.position.y + 1.0f,
                                gameObject.transform.position.z + Random.Range(-2.0f, 2.0f)),
                    Quaternion.identity, gameObject.transform) ;
            }

            TimeElapsed = 0.0f;

        }
    }
}

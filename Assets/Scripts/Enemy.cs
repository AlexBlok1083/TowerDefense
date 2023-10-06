using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Enemy : MonoBehaviour
{
    [SerializeField] PathCreator pathCreator;
    [SerializeField] float speed;
    float distanceTravelled;

    void Update()
    {
        Move();
        //Rotate() voor het rotaten van de sprite wanneer hij van loop richting veranderd.
        if (distanceTravelled >= 47)
        {
            Debug.Log("Enemy is on end of path");
        }
    }

    private void Move()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction: EndOfPathInstruction.Stop);
    }

  
}

using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.AI;

public class enemyAi : MonoBehaviour
{
    public NavMeshAgent badGuy;
    public float squareOfMovement = 20f;
    private float xMin;
    private float xMax;
    private float zMin;
    private float zMax;
    private float xPosition;
    private float zPosition;
    private float yPosition;
    public float closeEnof = 2f;



    // Start is called before the first frame update
    void Start()
    {
        xMin = -squareOfMovement;
        xMax = squareOfMovement;
        zMin = -squareOfMovement;
        zMax = squareOfMovement;

        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,new Vector3(xPosition, yPosition, zPosition)) <= closeEnof)
        {
            newLocation();
        }
    }

    public void newLocation()
    {
        yPosition = transform.position.y;
        xPosition = Random.Range(xMin, xMax);
        zPosition = Random.Range(zMin, zMax);
        badGuy.SetDestination(new Vector3(xPosition, yPosition, zPosition));
    }
}

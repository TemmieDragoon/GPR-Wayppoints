using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfollower : MonoBehaviour
{
    public int index;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float arrive;

    [SerializeField]
    private Path path;

    void Start()
    {
        path = GameObject.Find("saypointPapa").GetComponent<Path>();
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, path.GetNextWaypoint(index).Position) <= arrive)
        {
           // print("I made it!");
            if (index < path._Waypoints.Length - 1)
                index++;
            else
                index = 0;
        }
        else
        {
            transform.LookAt(path._Waypoints[index].Position);
            transform.position += transform.forward * speed * Time.deltaTime;
        }

    }
}

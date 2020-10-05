using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
  

    [SerializeField]
    private Transform _PapaWaypoint;

    public Waypoints[] _Waypoints;


    void Start()
    {
        _Waypoints = _PapaWaypoint.GetComponentsInChildren<Waypoints>();
    }
    /// <summary>
    /// Deze functie returned het volgende waypoint waar naartoe kan worden bewogen.
    /// </summary>
    public Waypoints GetNextWaypoint(int index)
    {

        // dit is nu niet goed, zorg ervoor dat het goede waypoint wordt teruggegeven.
        return _Waypoints[index];
    }
}

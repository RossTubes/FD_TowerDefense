using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{

    [SerializeField] private WayPoint[] wayPoints;

    public WayPoint GetPathStart()
        {
        return wayPoints[0];
    }

    public WayPoint GetPathEnd()
    {
        return wayPoints[wayPoints.Length - 1];
    }

    public WayPoint GetNextWaypoint(WayPoint currentWaypoint)
    {
       for (int i = 0; i < wayPoints.Length; i++)
        {
            if (wayPoints[i] == currentWaypoint)
            {
                return wayPoints[i + 1];
            }
        }
        return null;
        //return wayPoints[0];
    }
    // Start is called before the first frame update
    // Update is called once per frame
}

using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{

    public static Transform[] points;

    void Awake()
    {
        // TODO(jcollard 2022-02-01): You should abstract this method into the
        // method we talked about.
        InitWayPoints(this);
    }

    public static Transform[] InitWayPoints(Waypoints waypoints)
    {
        if (waypoints == null) throw new System.Exception("Cannot process null waypoints");
        points = new Transform[waypoints.transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = waypoints.transform.GetChild(i);
        }
        return points;
    }


}

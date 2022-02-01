using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {

    public static Transform[] points;

    void Awake ()
    {
        // TODO(jcollard 2022-02-01): You should abstract this method into the
        // method we talked about.
        points = new Transform [transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }



}

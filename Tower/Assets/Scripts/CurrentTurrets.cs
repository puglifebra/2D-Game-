using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentTurrets : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    public int CountTurrets(GameObject[] objects)
    {
        if (objects == null) throw new System.Exception("Cannot process null objects");
        int total = 0;
        foreach (GameObject obj in objects)
        {
            if(obj.tag == "Turret")
            {
                total = total + 1;
            }
        }
        return total;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Total Turrets: {CountTurrets(GameObject.FindGameObjectsWithTag("Turret"))}";
    }
}

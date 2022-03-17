using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;
    public UnityEngine.UI.Text text;

    void Start ()
    {
        Money = startMoney;
    }

    public int GetMoney(List<Enemy> enemies)
    {
        if (enemies == null) throw new System.Exception("Cannot Process Null Objects");
        foreach (Enemy e in enemies)
        {
            Money = Money + 5;
            Destroy(e);
        }
        return Money;
    }

    void Update()
    {
        text.text = $"Money: {Money}";
    }
    
}

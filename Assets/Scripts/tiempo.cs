using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempo : MonoBehaviour
{
    public Text textpoints;
    public int points;
    public int pointsPerSecond = 1;

    void Start()
    {
        InvokeRepeating("IncreasePoints", 0f, 1f);
    }
    void IncreasePoints()
    {
        points += pointsPerSecond;
        textpoints.text = "Puntos: " + points;
    }
}

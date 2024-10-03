using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearenemigo : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minXposition;
    public float maxXposition;
    public float minYposition;
    public float maxYposition;
    public float minZposition;
    public float maxZposition;
    private void Start()
    {
        Createenemy();
    }

    void Createenemy()
    {
        float xposition = Random.Range(minXposition, maxXposition);
        float yposition = Random.Range(minYposition, maxYposition);
        float zposition = Random.Range(minZposition, maxZposition);

        Vector3 positioncreate = new Vector3(xposition, yposition, zposition);

        GameObject enemigo = Instantiate(prefabEnemy, positioncreate, transform.rotation);

        Invoke("Createenemy", 1.5f);
    }
}

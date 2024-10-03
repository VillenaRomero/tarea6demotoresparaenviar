using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    private Rigidbody rigibody;
    public float speedz;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigibody.velocity = new Vector3(0, 0, -speedz);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
        }
    }
}

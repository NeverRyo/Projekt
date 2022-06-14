using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jednostronny : MonoBehaviour
{
    void OnTriggerStay(Collider collision)
    {
        GameObject thing = collision.gameObject;
        Rigidbody rigidbody = thing.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;

        float delta = 0.25f * 30f;

        if (transform.rotation.y == 0)
        {
            if (velocity.x < delta)
            {
                velocity.x = delta;
            }
        }
        else
        {
            if (velocity.x > -delta)
            {
                velocity.x = -delta;
            }
        }

        rigidbody.velocity = velocity;
    }
}
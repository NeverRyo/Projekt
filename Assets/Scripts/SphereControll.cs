using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControll : MonoBehaviour
{

    int layer = 0;
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {


        changeLayer();
        changePosition();
    }

    void changeLayer()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            bool isSomething = Physics.Raycast(transform.position, Vector3.forward, 2f);

            if (!isSomething)
            {
                layer = 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bool isSomething = Physics.Raycast(transform.position, Vector3.back, 2f);

            if (!isSomething)
            {
                layer = 0;
            }
        }

        float delta = (layer * 2f - 2f) - rigidbody.position.z;
        Vector3 velovicty = rigidbody.velocity;
        velovicty.z = delta * 3f;
        rigidbody.velocity = velovicty;
    }

    void changePosition()
    {
        Vector3 direction = Vector3.zero;

        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = (Vector3.forward* 10f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = (-Vector3.forward* 10f);
        }

        rigidbody.AddTorque(direction* 25f);
    }

}
      
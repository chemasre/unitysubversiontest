using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 100.0f;

    public enum Axis
    {
        x,
        y,
        z
    }

    public Axis axis;

    float rotation;



    // Start is called before the first frame update
    void Start()
    {
        rotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rotation += speed * Time.deltaTime;

        if(axis == Axis.x)
        {
            transform.rotation = Quaternion.Euler(rotation, 0, 0);
        }
        else if(axis == Axis.y)
        {
            transform.rotation = Quaternion.Euler(0, rotation, 0);
        }
        else if(axis == Axis.z)
        {
            transform.rotation = Quaternion.Euler(0, 0, rotation);
        }
    }
}

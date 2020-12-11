using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 100.0f;

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

        transform.rotation = Quaternion.Euler(rotation, 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMoveCar : MonoBehaviour
{
    public float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // to move the cars(obstacles)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

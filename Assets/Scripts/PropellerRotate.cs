using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{

    //private float degreesPerSecond  = 360.0f;
    private float speed = 720.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace leveldesign
{ 
public class rotateFinish : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotate();
    }
    void rotate()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesRotation : MonoBehaviour
{
    public float rotationspeed;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            print("mousex" + mouseX);
            transform.Rotate(transform.position.x, -mouseX * rotationspeed * Time.deltaTime, transform.position.z);
        }
      
    }
}
//---->  -
//---->   +

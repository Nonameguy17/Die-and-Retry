using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float movementspeed  = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Xvalue = Input.GetAxis("Vertical") * Time.deltaTime * movementspeed;
        float Zvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movementspeed;
        float Yvalue = 0f;
        transform.Translate(Xvalue,Yvalue,Zvalue);
    }
}

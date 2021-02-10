using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [SerializeField]
    float rotationVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {

            transform.Rotate(Vector3.up * Time.deltaTime * rotationVelocity);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotationVelocity);
        }if (Input.GetKey("w"))
        {

            transform.Rotate(Vector3.right * Time.deltaTime * rotationVelocity);
        }
        if (Input.GetKey("s"))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * rotationVelocity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPurly : MonoBehaviour
{
    // Start is called before the first frame update

    public float movementSpeed = 10f;
    public float rotationSpeed = 200f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = transform.forward * verticalInput * movementSpeed * Time.deltaTime;
        transform.Translate(movement);

        float rotation = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotation);
    }
}

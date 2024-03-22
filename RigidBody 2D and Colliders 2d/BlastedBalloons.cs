using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastedBaloons : MonoBehaviour
{

    // This function is called when another object enters a trigger collider attached to this object
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the character
        if (other.CompareTag("Purly"))
        {
            // Here you can add effects like a sound or particle effect to simulate the burst
            Debug.Log("Balloon bursts!");

            // Finally, destroy the balloon object
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

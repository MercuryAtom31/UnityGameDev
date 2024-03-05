using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSnowball : MonoBehaviour
{
    GameObject target;
    public float followSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Purly");
    }

    // Update is called once per frame
    void Update()
    {
            // Move the snowball towards the target's position with a slower speed
            Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}

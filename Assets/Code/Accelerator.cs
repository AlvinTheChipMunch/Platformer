using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<FirstPersonMovement>().speed += 10;
            other.gameObject.GetComponent<FirstPersonMovement>().runSpeed += 20;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<FirstPersonMovement>().speed -= 10;
            other.gameObject.GetComponent<FirstPersonMovement>().runSpeed -= 20;
        }
    }
}

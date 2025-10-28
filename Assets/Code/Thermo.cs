using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thermo : MonoBehaviour
{
    public float heat = 37;
    public float healthDepleteRate = 2f;
    public Health health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heat -= Time.deltaTime;
        if (heat <= 25)
        {
            health.LoseHealth(0.001f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fire")
        {
            heat += Time.deltaTime * 3;
            if (heat >= 40)
            {
                health.LoseHealth(100);
            }
        }
    }
}

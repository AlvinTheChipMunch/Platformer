using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 1;
    public float damage = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.TryGetComponent<Health>(out Health charHealth);
        charHealth.LoseHealth(damage);
        Destroy(gameObject);
    }
}

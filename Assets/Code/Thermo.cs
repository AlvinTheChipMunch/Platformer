using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Thermo : MonoBehaviour
{
    public float heat = 37;
    public float healthDepleteRate = 2f;
    public Health health;
    public bool nearfire;
    public TextMeshProUGUI tempText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nearfire)
        {
            heat += Time.deltaTime;
        }
        else
        {
            heat -= Time.deltaTime;
        }
        if (heat <= 25)
        {
            health.LoseHealth(0.001f);
        }
        if (heat > 40)
        {
            health.LoseHealth(0.001f);
        }
        tempText.text = Math.Round(heat+1) + "";
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fire")
        {
         nearfire = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Fire")
        {
            nearfire = false;
        }
    }
}

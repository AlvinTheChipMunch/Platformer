using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float seconds;
    public float minutes;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if(seconds <= 0)
        {
            minutes -= 1;
            seconds = 60;
        }

        if(minutes < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        timerText.text = (int)minutes + ":" + (int)seconds;
    }
}

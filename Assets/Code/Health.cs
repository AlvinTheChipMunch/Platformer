using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health = 1;
    public int coin;
    public TextMeshProUGUI coinText;
    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.tag == "Player")
        {
            coinText.text = 0 + "";
            healthSlider.maxValue = health;
            healthSlider.value = health;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoseHealth(float amount)
    {
        health -= amount;
        if (transform.tag == "Player")
        {
            healthSlider.value = health;
        }
        if(health <= 0)
        {
            if(transform.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                return;
            }
            Destroy(gameObject);
        }
    }
    public void CollectCoin(int amount)
    {
        coin += amount;
        coinText.text = coin + "";
    }
}

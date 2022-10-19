using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;

    //the gradient colour of our health bar
    public Gradient healthColour;
    public Image healthBar;

    private void Update()
    {
        // Change how much the bar is filled based off how much health we have left
        healthBar.fillAmount = Mathf.Clamp01(currentHealth / maxHealth);
        // Change the colour according to the amount of health left
        healthBar.color = healthColour.Evaluate(healthBar.fillAmount);
    }








}

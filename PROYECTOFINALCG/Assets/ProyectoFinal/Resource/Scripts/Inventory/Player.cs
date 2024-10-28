using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public int Health;

    public TMP_Text HealthText;

    public void Awake()
    {
        Instance = this; 
    }

    public void IncreaseHealth(int value)
    {
        Health += value;
        HealthText.text = $"HP:{Health}";
    }
}

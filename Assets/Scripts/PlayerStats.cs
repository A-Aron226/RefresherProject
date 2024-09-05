using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] Stat maxHealth;
    [SerializeField] Stat currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth.amount = maxHealth.amount; //Taking the amount from Stat script
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

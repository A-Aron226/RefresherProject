using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //Utilizes Observer pattern

public class TriggerZone : MonoBehaviour
{

    [SerializeField] UnityEvent OnEnter;
    [SerializeField] UnityEvent OnExit;
    [SerializeField] Stat currentHealth;

    [SerializeField] bool decreaseHealth;
    float decreaseDelay = 2.0f;

    private void Update()
    {
        if (decreaseHealth)
        {
            decreaseDelay -= Time.deltaTime;
            if (decreaseDelay <= 0)
            {
                currentHealth.amount -= 10;
                decreaseDelay = 2.0f;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        OnEnter?.Invoke(); //Checks if something is null ('?') before performing action
        decreaseHealth = true;       
    }

    private void OnTriggerExit(Collider other)
    {
        OnExit?.Invoke();
        decreaseHealth = false;
    }
}

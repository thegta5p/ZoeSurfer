using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{

    public float chanceToSpawn = 0.10f;
    private GameObject powerUp;

    private void Awake()
    {
        powerUp = transform.GetChild(0).gameObject;
        OnDisable();
        
    }

    private void OnEnable()
    {
        if (Random.Range(0.0f, 1.0f) > chanceToSpawn)
        {
            return;
        }

        powerUp.SetActive(true);
    }

    private void OnDisable()
    {
        powerUp.SetActive(false);
        
    }
}

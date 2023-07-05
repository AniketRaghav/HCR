using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPointScript : MonoBehaviour
{
    public GameObject Ground;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(Ground.gameObject.CompareTag("Ground"))
            {
                Ground.GetComponent<EnvironmentGenerator>().SpawnNextLevel();   
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPointScript : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Vehicle;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Work");
        }
    }
}

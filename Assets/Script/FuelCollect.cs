using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuelCollect : MonoBehaviour
{
    // Start is called before the first frame update
    public static FuelController instance;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag("Player"))
        {
            FuelController.instance.FillFuel();
            Destroy(gameObject);
        }
    }
}

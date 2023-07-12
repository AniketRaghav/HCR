using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class EnvironmentGenerator : MonoBehaviour
{


    public GameObject Ground1;
    public GameObject Ground2;
    public GameObject Ground3;
    public GameObject Ground4;
    public GameObject Ground5;
    public GameObject Ground6;
    public GameObject Ground7;
    public GameObject Ground8;
    public GameObject Ground9;
    public Transform EndPoint;
    public Transform SpawnPoint;
    private GameObject GroundtoSpawn;
    public void Awake()
    {
        float RandomNumber = Random.Range(1, 9);
        if (RandomNumber == 1)
        {
            GroundtoSpawn = Ground1;
        }
        else if (RandomNumber == 2)
        {
            GroundtoSpawn = Ground2;
        }
        else if (RandomNumber == 3)
        {
            GroundtoSpawn = Ground3;
        }
        else if (RandomNumber == 4)
        {
            GroundtoSpawn = Ground4;
        }
        else if (RandomNumber == 5)
        {
            GroundtoSpawn = Ground5;
        }
        else if (RandomNumber == 6)
        {
            GroundtoSpawn = Ground6;
        }
        else if (RandomNumber == 7)
        {
            GroundtoSpawn = Ground7;
        }
        else if (RandomNumber == 8)
        {
            GroundtoSpawn = Ground8;
        }
        else if (RandomNumber == 9)
        {
            GroundtoSpawn = Ground9;
        }
        
    }

    public void SpawnNextLevel()
    {
        Instantiate(GroundtoSpawn, EndPoint);

    }
   


}

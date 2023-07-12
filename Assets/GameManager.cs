using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;
    public GameObject Ground1;
    public GameObject Ground2;
    public GameObject Ground3;
    public GameObject Ground4;
    public GameObject Ground5;
    public GameObject Ground6;
    public GameObject Ground7;
    public GameObject Ground8;
    public GameObject Ground9;
<<<<<<< Updated upstream
    public Transform EndPoint;
    public GameObject GroundtoSpawn;
=======
    public GameObject Ground10;
    public Vector3 EndPoint;
    private GameObject GroundtoSpawn;
    
>>>>>>> Stashed changes

   
    void Awake()
    {
     
        if (instance ==null)
        {
            instance = this;
        }
        Time.timeScale = 1f;
<<<<<<< Updated upstream
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
=======
        
>>>>>>> Stashed changes
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;

    }
    public void SpawnNextLevel()
<<<<<<< Updated upstream
    {
        Instantiate(GroundtoSpawn, EndPoint);

=======
   {
        float RandomNumber = Random.Range(1, 10);
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
        else if (RandomNumber == 10)
       {
          GroundtoSpawn = Ground10;
      }
       int N = 0;
       Instantiate(GroundtoSpawn, EndPoint ,Quaternion.identity);
        GroundtoSpawn.transform.parent = null;
        MoveTrasnform();
        EndPoint += new Vector3(100f, 0f, 0f);
    }
    private void MoveTrasnform()
    {
      
>>>>>>> Stashed changes
    }
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnStartPressedD()
    {
        Input.GetKeyDown(KeyCode.D);
    }
}

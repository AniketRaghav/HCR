using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private EnvironmentGenerator terrain1, terrain2;
    [SerializeField] private Vector2 terrainStepPos;

    private int terrainSwapIndex = 0;
    private Vector2 terrainGenPos = Vector3.zero;

    void Awake()
    {
        if(instance ==null)
        {
            instance = this;
        }
        Time.timeScale = 1f;
    }

    private void Start()
    {
        SwapTerrain(0);
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SwapTerrain(int terrainIndex)
    {
        if (terrainIndex != terrainSwapIndex) return;

        if (terrainSwapIndex == 0)
        {
            terrainSwapIndex = 1;
            terrain1.GenerateTerrain(terrainGenPos);
        }
        else if (terrainSwapIndex == 1)
        {
            terrainSwapIndex = 0;
            terrain2.GenerateTerrain(terrainGenPos);
        }

        terrainGenPos += terrainStepPos;
    }
}

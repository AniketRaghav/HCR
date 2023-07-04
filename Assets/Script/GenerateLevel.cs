using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    private Vector2 _startPosition;
    public Transform _playerTrans;
    public GameObject Ground;
    public Transform VectoSpawn;
    void Start()
    {
        _startPosition = _playerTrans.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 distance = (Vector2)_playerTrans.position - _startPosition;
        distance.y = 0f;
        if (distance.x < 0)
        {
            distance.x = 0;
        }
        
        
    }
   
}

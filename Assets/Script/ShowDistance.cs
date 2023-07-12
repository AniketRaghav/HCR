using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowDistance : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextMeshProUGUI;
    [SerializeField] private Transform _playerTrans;
    public GameObject GameManager;

    private Vector2 _startPosition;

    private void Start()
    {
        _startPosition = _playerTrans.position;
    }
    private void Update()
    {
        Vector2 distance = (Vector2)_playerTrans.position - _startPosition;
        distance.y = 0f;
        
        m_TextMeshProUGUI.text = distance.x.ToString("F0") + "m";
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _frontTireRB;
    [SerializeField] private Rigidbody2D _backTireRB;
    [SerializeField] private Rigidbody2D _carRb;
    [SerializeField] private float _speed = 150f;
    [SerializeField] private float _rotationspeed = 300f;
    public GameObject GameManager;

    private float _moveInput;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    
    private void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");
        if (transform.position.x - initialPosition.x >= 75.0f)
        {
            CallFunction();
            initialPosition = transform.position;
        }
    }
    private void FixedUpdate()
    {
        _frontTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _carRb.AddTorque(_moveInput * _speed * Time.fixedDeltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Work");
;    }
    private void CallFunction()
    {
        GameManager.GetComponent<GameManager>().SpawnNextLevel();
    }
    public void OnStartPressedD()
    {
        Input.GetKeyDown(KeyCode.D);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverCar : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _frontTireRB;
    [SerializeField] private Rigidbody2D _backTireRB;
    [SerializeField] private Rigidbody2D _carRb;
    [SerializeField] private float _spead = 150f;
    [SerializeField] private float _rotationSpeed = 300f;

    private float _moveInput;

    private void Update()
    {
        _moveInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        _frontTireRB.AddTorque(-_moveInput * _spead * Time.fixedDeltaTime);
        _backTireRB.AddTorque(-_moveInput * _spead * Time.fixedDeltaTime);
        _carRb.AddTorque(_moveInput * _rotationSpeed * Time.fixedDeltaTime);
    }
}
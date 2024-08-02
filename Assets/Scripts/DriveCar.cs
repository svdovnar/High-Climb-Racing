using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
    [SerializeField] private Rigidbody2D frontTireRB;
    [SerializeField] private Rigidbody2D backTireRB;
    [SerializeField] private Rigidbody2D carRB;
    [SerializeField] private float rotationSpeed = 300f;
    [SerializeField] private float moveSpeed = 150f;

    private float moveInput;
    private void Update()
    {
       moveInput = Input.GetAxisRaw("Horizontal"); 
    }
    private void FixedUpdate()
    {
        frontTireRB.AddTorque(-moveInput * moveSpeed * Time.fixedDeltaTime);
        backTireRB.AddTorque(-moveInput * moveSpeed * Time.fixedDeltaTime);
        carRB.AddTorque(moveInput * rotationSpeed * Time.fixedDeltaTime);
    }
}

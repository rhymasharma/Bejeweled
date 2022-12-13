using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce = 300f;
    private bool _shouldJump;


    private void Awake() => _rigidbody = GetComponent<Rigidbody>();


    private void Update()
    {
        if (_shouldJump == false)
            _shouldJump = Input.GetKeyDown(KeyCode.Space);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (_shouldJump)
        {
            _rigidbody.AddForce(_jumpForce * Vector3.up);
            _shouldJump = false;
        }
    }
}
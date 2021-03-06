﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ForkliftBasicMovment : MonoBehaviour
{
    [Header("Movment Options")]
    [SerializeField] FloatVariable movmentSpeed;
    // [SerializeField] Vector3Variable forwardAxis;
    [SerializeField] Vector3Variable rotationAxis;
    [SerializeField] FloatVariable movementStick;

    private float currSpeed;
    private Rigidbody rb;
    MappingRotation mr;

    private void Awake()
    {
        mr = GetComponent<MappingRotation>();
        rb = GetComponent<Rigidbody>();

    }

    void Start()
    {

    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    currSpeed = -movmentSpeed.value;

        //}
        //if (Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    currSpeed = 0;
        //}

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    currSpeed = movmentSpeed.value;

        //}
        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    currSpeed = 0;
        //}

        if (movementStick.value == 1)
        {
            currSpeed = movmentSpeed.value;
        }

        if (movementStick.value == -1)
        {
            currSpeed = -movmentSpeed.value;
        }
        if (movementStick.value == 0)
        {
            currSpeed = 0;
        }

        Moving(currSpeed, transform.forward, rotationAxis.value);
    }

    void FixedUpdate()
    {
        //Moving(currSpeed, transform.forward, rotationAxis.value);
    }

    public void Moving(float speed, Vector3 forwardAxis, Vector3 rotationAxis)
    {
        if (mr.rotationChanged)
        {
            transform.Rotate(speed * 5 * rotationAxis);
        }

        rb.velocity = speed * forwardAxis;
        //rb.AddForce(speed * forwardAxis);
    }

    #region nothing
    //public void MoveRight()
    //{
    //    currSpeed = movmentSpeed.value;
    //}


    //public void MoveLeft()
    //{
    //    currSpeed = -movmentSpeed.value;
    //}


    //public void StopMovement()
    //{
    //    currSpeed = 0;
    //}
    #endregion
}

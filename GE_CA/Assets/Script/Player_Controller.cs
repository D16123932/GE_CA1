﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private CharacterController cc;

    public float moveSpeed;
    public float jumpSpeed;

    private float horizontalMove, verticalMove;
    private Vector3 dir;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis("Vertical") * moveSpeed;

        dir = transform.forward * verticalMove + transform.forward * horizontalMove;
        cc.Move(dir * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private Vector3 postition;
    private CharacterController controller;

    public float moveSpeed = 10f, gravity = 9.81f, jumpseed = 30f;
    private int jumpCount;
    public int jumpCountMax = 2;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        postition.x = moveSpeed * Input.GetAxis("Horizontal");
        postition.y -= gravity;
        
    }
}

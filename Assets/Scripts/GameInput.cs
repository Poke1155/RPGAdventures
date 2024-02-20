using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private Rigidbody rb;
    private PlayerInputActions playerInputActions;
    [SerializeField] private float moveSpeed = 5f;
    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

    }

    public Vector2 getVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }
    

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = getVectorNormalized();
        float xdir = movement.x;
        float ydir = movement.y;
        transform.Translate(xdir * Time.deltaTime, ydir * Time.deltaTime, 0f);
    }
}

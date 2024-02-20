using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementActions : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private GameInput gameInput;
    // Update is called once per frame
    void Update()
    {
        Vector2 movement = gameInput.getVectorNormalized();
        Vector3 moveDir = new Vector3(movement.x, 0f, movement.y);
        transform.position += moveDir * Time.deltaTime * moveSpeed;
    }
}

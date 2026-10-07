using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class Movement : MonoBehaviour
{
    public InputAction LeftAction;

    public InputAction MoveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = MoveAction.ReadValue<Vector3>();
        Debug.Log(move);
        Vector3 position = (Vector3)transform.position + move * 0.01f;
        transform.position = position;
    }
}

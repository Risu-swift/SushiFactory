using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public InputSystem_Actions Actions;

    private Vector2 _pointerPosition;

    public static event Action<Vector3> OnMouseClicked; 
    void Update()
    {
        // Get the mouse device
        Mouse mouse = Mouse.current;

        if (mouse == null)
        {
            return; // No mouse connected
        }

        // Check for left mouse button press this frame
        if (mouse.leftButton.wasPressedThisFrame)
        {
            var position = mouse.position.ReadValue();
            Debug.Log("Left click THIS FRAME");
            OnMouseClicked?.Invoke(position);
        }

        // Check if left mouse button is held down
        if (mouse.leftButton.isPressed)
        {
            Debug.Log("Left button is HELD");
        }

        // Check for left mouse button release this frame
        if (mouse.leftButton.wasReleasedThisFrame)
        {
            Debug.Log("Left click RELEASED");
        }

        // You can also check right and middle buttons
        if (mouse.rightButton.wasPressedThisFrame)
        {
            Debug.Log("Right click THIS FRAME");
        }
    }
}

using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Create free-standing Actions.
        var lookAction = new InputAction("look", binding: "<Gamepad>/leftStick");
        var moveAction = new InputAction("move", binding: "<Gamepad>/rightStick");

        lookAction.AddBinding("<Mouse>/delta");
        moveAction.AddCompositeBinding("Dpad")
            .With("Up", "<Keyboard>/w")
            .With("Down", "<Keyboard>/s")
            .With("Left", "<Keyboard>/a")
            .With("Right", "<Keyboard>/d");
        // Enable a single action.
        lookAction.Enable();
        moveAction.Enable();

        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
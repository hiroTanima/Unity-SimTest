using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerInput : Singleton<PlayerControllerInput>
{
    public Vector2 MoveInput { get; private set; } = Vector2.zero;
    public bool InteractInput { get; private set; } = false;

    InputActions _input = null;

    private void OnEnable()
    {
        _input = new InputActions();
        _input.Player.Enable();

        _input.Player.Move.performed += SetMove;
        _input.Player.Move.canceled += SetMove;

        _input.Player.Interact.performed += SetInteract;
        _input.Player.Interact.canceled += SetInteract;
    }

    private void OnDisable()
    {
        _input.Player.Disable();

        _input.Player.Move.performed -= SetMove;
        _input.Player.Move.canceled -= SetMove;

        _input.Player.Interact.performed -= SetInteract;
        _input.Player.Interact.canceled -= SetInteract;
    }

    private void SetMove(InputAction.CallbackContext ctx)
    {
        MoveInput = ctx.ReadValue<Vector2>();
    }

    private void SetInteract(InputAction.CallbackContext ctx)
    {
        InteractInput = ctx.ReadValue<bool>();
    }
}

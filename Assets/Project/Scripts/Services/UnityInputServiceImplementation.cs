using UnityEngine;
using UnityEngine.InputSystem;

public class UnityInputServiceImplementation : IInputService
{
    private readonly UnityInput _input;
    private Vector2 _movement = Vector2.zero;
    private Vector2 _look = Vector2.zero;

    public Vector2 GetMovement => _movement;
    public Vector2 GetLook => _look;

    public UnityInputServiceImplementation()
    {
        if (_input == null)
        {
            _input = new UnityInput();

            _input.Player.Move.performed += Move;
            _input.Player.Move.canceled += Move;

            _input.Player.Look.performed += Look;
            _input.Player.Look.canceled += Look;

            _input.Player.Enable();
        }
    }

    private void Move(InputAction.CallbackContext context)
    => _movement = context.ReadValue<Vector2>();

    private void Look(InputAction.CallbackContext context)
    => _look = context.ReadValue<Vector2>();

    public void Dispose()
    {
        if (_input.Player.enabled)
            _input.Player.Disable();
    }
}
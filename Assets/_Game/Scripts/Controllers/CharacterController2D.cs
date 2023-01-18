using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D = null;
    //[SerializeField] private PlayerControllerInput _input = null;

    private Vector2 _playerMoveInput = Vector2.zero;

    [Header("Movement")]
    [SerializeField] private float _movementSpeed = 10f;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _playerMoveInput = GetMoveInput();
        PlayerMove();
    }
    private Vector2 GetMoveInput()
    {
        return new Vector2(PlayerControllerInput.Instance.MoveInput.x, PlayerControllerInput.Instance.MoveInput.y);
    }

    private void PlayerMove()
    {
        _playerMoveInput = new Vector2(_playerMoveInput.x * _movementSpeed,
                                       _playerMoveInput.y * _movementSpeed);
        _rigidbody2D.velocity = _playerMoveInput;
    }

}

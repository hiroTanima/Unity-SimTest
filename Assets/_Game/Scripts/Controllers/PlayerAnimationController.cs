using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private GameObject playerUp,playerDown,playerSide;

    private Vector2 _playerDirection = Vector2.zero;

    private bool isFacingRight = true;

    private void Update()
    {
        if (playerUp == null || playerDown == null || playerSide == null) return;

        _playerDirection = PlayerControllerInput.Instance.MoveInput;

        if(_playerDirection.y < 0)
        {
            playerUp.SetActive(false);
            playerSide.SetActive(false);
            playerDown.SetActive(true);
        }
        else if (_playerDirection.y > 0)
        {
            playerUp.SetActive(true);
            playerSide.SetActive(false);
            playerDown.SetActive(false);
        }

        if(_playerDirection.x > 0 || _playerDirection.x < 0)
        {
            playerUp.SetActive(false);
            playerSide.SetActive(true);
            playerDown.SetActive(false);
        }

        if(_playerDirection.x > 0 && !isFacingRight)
        {
            playerSide.transform.localScale = Vector3.one;
            isFacingRight = true;
        }

        if (_playerDirection.x < 0 && isFacingRight)
        {
            playerSide.transform.localScale = new Vector3(-1f,1f,1f);
            isFacingRight = false;
        }
    }

}

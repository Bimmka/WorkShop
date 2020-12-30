using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1MoveSystem : PlayerMoveSystem
{
    protected override void OnEnable()
    {
        playerInputs.Player1.Enable();
    }

    protected override void OnDisable()
    {
        playerInputs.Player1.Disable();
    }

    protected override void InputAxis()
    {
        moveDirection = playerInputs.Player1.Move.ReadValue<Vector2>();

        base.InputAxis();
    }
}

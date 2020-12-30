using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2MoveSystem : PlayerMoveSystem
{
    protected override void OnEnable()
    {
        playerInputs.Player2.Enable();
    }

    protected override void OnDisable()
    {
        playerInputs.Player2.Disable();
    }

    protected override void InputAxis()
    {
        moveDirection = playerInputs.Player2.Move.ReadValue<Vector2>();

        base.InputAxis();
    }
}

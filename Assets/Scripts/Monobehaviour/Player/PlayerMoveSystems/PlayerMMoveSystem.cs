using Photon.Pun;
using UnityEngine;

public class PlayerMMoveSystem : PlayerMoveSystem
{
    private PhotonView photonView;
    protected override void OnEnable()
    {
        photonView = GetComponent<PhotonView>();
        playerInputs.PlayerM.Enable();
    }

    protected override void OnDisable()
    {
        playerInputs.PlayerM.Disable();
    }

    protected override void Update()
    {
        if (!photonView.IsMine) return;
        base.Update();
    }

    protected override void InputAxis()
    {
        moveDirection = playerInputs.PlayerM.Move.ReadValue<Vector2>();

        base.InputAxis();
    }
}

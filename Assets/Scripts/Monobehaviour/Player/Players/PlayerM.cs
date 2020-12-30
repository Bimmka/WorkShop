using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : Player
{
    private PhotonView photonView;
    protected override void OnEnable()
    {
        photonView = GetComponent<PhotonView>();
        playerInputs.PlayerM.SetBomb.Enable();
    }

    protected override void OnDisable()
    {
        playerInputs.PlayerM.SetBomb.Disable();
    }

    protected override void Update()
    {
        if (!photonView.IsMine) return;
        base.Update();
    }

    protected override void TrySetBomb()
    {
        if (playerInputs.PlayerM.SetBomb.triggered && currentNumberOfBomb > 0) SetBomb();
    }
}

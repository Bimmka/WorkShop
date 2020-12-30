public class Player2 : Player
{
    protected override void OnEnable()
    {
        playerInputs.Player2.SetBomb.Enable();
    }

    protected override void OnDisable()
    {
        playerInputs.Player2.SetBomb.Disable();
    }

    protected override void TrySetBomb()
    {
        if (playerInputs.Player2.SetBomb.triggered && currentNumberOfBomb > 0) SetBomb();
    }
}

public class Player1 : Player
{
    protected override void OnEnable()
    {
        playerInputs.Player1.SetBomb.Enable();
    }

    protected override void OnDisable()
    {
        playerInputs.Player1.SetBomb.Disable();
    }

    protected override void TrySetBomb()
    {
        if (playerInputs.Player1.SetBomb.triggered && currentNumberOfBomb > 0) SetBomb();
    }
}

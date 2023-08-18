public class SlopKitchenService
{
    public float potsOfSlop { get; private set; }
    public float slopPerClick { get; set; }
    public SlopKitchenService()
    {
        potsOfSlop = 0;
        slopPerClick = 1;
    }

    public void SlopButtonClick()
    {
        potsOfSlop += slopPerClick;
    }
}
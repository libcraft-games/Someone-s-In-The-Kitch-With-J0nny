public class SlopKitchenService
{
    public float PotsOfSlop { get; private set; }
    public float SlopPerClick { get; set; }
    public int TurkeyFriers { get; set; }

    private const float TURKEY_FRIER_SLOP_VALUE = 1;
    public int TurkeyFryerSlopCost = 20;

    public SlopKitchenService()
    {
        PotsOfSlop = 0;
        SlopPerClick = 1;
        TurkeyFriers = 0;
    }

    public void SlopButtonClick()
    {
        PotsOfSlop += SlopPerClick;
    }

    public void CalculateAutoClicks()
    {
        PotsOfSlop += TurkeyFriers * TURKEY_FRIER_SLOP_VALUE;
    }

    public void PurchaseTurkeyFrier()
    {
        if (PotsOfSlop >= TurkeyFryerSlopCost)
        {
            PotsOfSlop -= TurkeyFryerSlopCost;
            TurkeyFriers++;
            TurkeyFryerSlopCost *= 2;
        }
    }
}
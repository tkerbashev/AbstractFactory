namespace AbstractFactory
{
    public interface IBeverage
    {
        IBeverageService PrepareBeverageService();
        IDrinkwareService PrepareDrinkwareService();
    }
}

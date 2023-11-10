namespace AbstractFactory
{
    internal class CoffeeFactory : IBeverage
    {
        public IBeverageService PrepareBeverageService( )
        {
            return new CoffeeService();
        }

        public IDrinkwareService PrepareDrinkwareService( )
        {
            return new CoffeeCupService( );
        }
    }
}

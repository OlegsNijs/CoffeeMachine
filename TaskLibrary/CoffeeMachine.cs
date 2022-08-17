namespace TaskLibrary
{
    public class CoffeeMachine
    {
        public double CoinValue(double coin1, double coin2, double coin3, double coin4)
        {
            return coin1 + coin2 + coin3 + coin4;
        }

        public string CoinInfo(double coin1, double coin2, double coin3, double coin4)
        {
            double result = coin1 + coin2 + coin3 + coin4;
            return "The used coin values are " + coin1.ToString() + " " + coin2.ToString() + " " + coin3.ToString() + " " + coin4.ToString()
                + "The total is " + result;
        }

        public string GetProduct(double coin1, double coin2, double coin3, double coin4, string productLatte, double lattePrice, string productCapuchino,
            double capuchinoPrice, string noMoney)
        {
            double result = coin1 + coin2 + coin3 + coin4;
            if (result >= lattePrice)
            {
                return productLatte;
            }
            else if (result >= capuchinoPrice)
            {
                return productCapuchino;
            }
            return noMoney;
        }

        public double GetChange(double coin1, double coin2, double coin3, double coin4, string productLatte, double lattePrice, string productCapuchino,
            double capuchinoPrice, string noMoney)
        {
            double result = coin1 + coin2 + coin3 + coin4;
            if (result >= lattePrice)
            {
                return result - lattePrice;
            }
            else if (result <= capuchinoPrice)
            {
                throw new ArgumentException();
            }
            return result- capuchinoPrice;
        }
    }
}
   
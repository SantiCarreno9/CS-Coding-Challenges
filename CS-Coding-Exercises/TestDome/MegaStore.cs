namespace TestDome;

public class MegaStore
{
    public enum DiscountType
    {
        Standard,
        Seasonal,
        Weight
    }

    public static double GetDiscountedPrice(double cartWeight,
                                            double totalPrice,
                                            DiscountType discountType)
    {
        double discountedPrice = totalPrice;
        switch (discountType)
        {
            case DiscountType.Standard:
                discountedPrice *= (1 - 0.06);
                break;
            case DiscountType.Seasonal:
                discountedPrice *= (1 - 0.12);
                break;
            case DiscountType.Weight:
                discountedPrice *= cartWeight <= 10 ? (1 - 0.06) : (1 - 0.18);
                break;
            default:
                break;
        }

        return discountedPrice;
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(GetDiscountedPrice(12, 100, DiscountType.Weight));
    //}
}
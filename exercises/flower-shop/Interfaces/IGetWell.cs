namespace flower_shop
{
    public interface IGetWell : IBirthday, IMothersDay
    {
        double StemLength { get; set; }
        string Color { get; set; }
    }
}
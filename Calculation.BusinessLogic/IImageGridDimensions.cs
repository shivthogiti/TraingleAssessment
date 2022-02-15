namespace Calculation.BusinessLogic
{
    public interface IImageGridDimensions
    {
        int Height { get; set; }

        int Width { get; set; }

        int EachColumnSize { get; set; }
    }
}
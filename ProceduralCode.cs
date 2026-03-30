namespace knightmoves;
public class Rectangle
{
    private int length;
    private int height;

    public Rectangle(int length, int height)
    {
        this.length = length;
        this.height = height;
    }

    public int CalculateArea()
    {
        return this.length * this.height;
    }
}

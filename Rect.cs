public class Rect
{
    public float height;
    public float width;
    public float x;
    public float y;

    public bool Overlap(Rect rect)
    {
        return x + width >= rect.x && y + height >= rect.y && x<rect.x + rect.width && y<rect.y + rect.height;
    }
}
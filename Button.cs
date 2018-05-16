public class Button
{
    public Button(string text)
    {
        this.text = text;
    }
    protected string text;
}

public enum Color
{
    Yellow,
    Green,
    Red,
    Blue,
    Orange
}

public class ColoredButton : Button
{
    public ColoredButton(string text, Color color)
        : base(text)
    {
        this.color = color;
    }
    private Color color;
}
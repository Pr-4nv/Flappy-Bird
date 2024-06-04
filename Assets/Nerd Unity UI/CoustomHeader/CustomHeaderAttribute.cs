namespace NerdStudios.CustomHeader
{
    using UnityEngine;

    public enum HeaderColor
    {
        Red,
        Green,
        Blue,
        Yellow,
        Cyan,
        Magenta,
        White,
        Black,
        Gray
    }

    public class CustomHeaderAttribute : PropertyAttribute
    {
        public string header;
        public Color backgroundColor;
        public int fontSize;

        public CustomHeaderAttribute(string header, HeaderColor color, int fontSize = 14)
        {
            this.header = header;
            this.backgroundColor = GetColorFromEnum(color);
            this.fontSize = fontSize;
        }

        private Color GetColorFromEnum(HeaderColor color)
        {
            switch (color)
            {
                case HeaderColor.Red:
                    return Color.red;
                case HeaderColor.Green:
                    return Color.green;
                case HeaderColor.Blue:
                    return Color.blue;
                case HeaderColor.Yellow:
                    return Color.yellow;
                case HeaderColor.Cyan:
                    return Color.cyan;
                case HeaderColor.Magenta:
                    return Color.magenta;
                case HeaderColor.White:
                    return Color.white;
                case HeaderColor.Black:
                    return Color.black;
                case HeaderColor.Gray:
                    return Color.gray;
                default:
                    return Color.white;
            }
        }
    }
}

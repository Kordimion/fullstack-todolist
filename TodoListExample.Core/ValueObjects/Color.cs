using System.Security.Cryptography.X509Certificates;
using TodoListExample.Core.Common;
using TodoListExample.Core.Enums;
using TodoListExample.Core.Exceptions;

namespace TodoListExample.Core.ValueObjects;

public partial class Color : ValueObject
{
    private readonly SupportedColorCode _color;

    //TODO: test for correct conversion
    public string CodeString => $"#{_color.ToString("X")[2..]}";

    //TODO: test for correct conversion
    public int CodeInt => (int) _color;

    //TODO: test for correct conversion
    public string Name
    {
        get
        {
            var temp = _color.ToString("G");
            var res = "" + temp[0];
            for (var i = 1; i < temp.Length; i++)
            {
                if (char.IsUpper(temp[i]))
                {
                    res += ' ';
                }

                res += temp[i];
            }

            return res;
        }
    }

    public Color(SupportedColorCode color) => _color = color;

    //TODO: test that this method throws UnsupportedColorCodeException when given unsupported color code
    public Color(int color)
    {
        if (!Enum.IsDefined(typeof(SupportedColorCode), color))
        {
            throw new UnsupportedColorCodeException($"Color {color} is not supported");
        }
        _color = (SupportedColorCode) color;
    }

    //TODO: test this does not throw an exception
    public static IEnumerable<Color> SupportedColors()
    {
        return Enum.GetValues<SupportedColorCode>().Select(code => new Color(code));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _color;
    }
}
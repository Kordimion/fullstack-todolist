using TodoListExample.Core.Common;
using TodoListExample.Core.Enums;

namespace TodoListExample.Core.ValueObjects;

public class Color : ValueObject
{
    private readonly SupportedColorCode _color;

    //TODO: test for correct conversion
    public string CodeString => $"#{_color:X}";

    //TODO: test for correct conversion
    public int CodeInt => (int) _color;

    //TODO: test for correct conversion
    public string Name => $"{_color:G}";

    public Color(SupportedColorCode color) => _color = color;

    //TODO: test that this method throws UnsupportedColorCodeException when given unsupported color code
    public Color(int color)
    {
        _color = (SupportedColorCode) color;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _color;
    }
}
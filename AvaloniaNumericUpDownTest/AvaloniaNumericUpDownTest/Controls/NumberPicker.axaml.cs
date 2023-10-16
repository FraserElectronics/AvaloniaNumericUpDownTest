using Avalonia;
using Avalonia.Controls.Primitives;

namespace AvaloniaNumericUpDownTest.Controls;

public class NumberPicker : TemplatedControl
{
    /// <summary>
    /// Gets or sets the number in the NumericUpDown control.
    /// </summary>
    public static readonly DirectProperty<NumberPicker,double> RealValueProperty =
    AvaloniaProperty.RegisterDirect<NumberPicker, double>(nameof(RealValue), o => o.RealValue, ( o, v ) => o.RealValue = v );
    private double _realValue;
    public double RealValue
    {
        get => _realValue;
        set => SetAndRaise( RealValueProperty, ref _realValue, value );
    }
}
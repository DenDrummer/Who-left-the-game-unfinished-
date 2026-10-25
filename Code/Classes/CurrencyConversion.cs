using Godot;

partial class CurrencyConversion : Resource
{
    [Export]
    Currency weakerCurrency;
    [Export]
    Currency strongerCurrency;
    [Export]
    double conversionRate;
}

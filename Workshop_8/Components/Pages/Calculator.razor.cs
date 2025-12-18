namespace Workshop_8.Components.Pages;

public partial class Calculator
{
    public double Num1 { get; set; }
    public double Num2 { get; set; }
    public double Result { get; set; }

    public void Add() => Result = Num1 + Num2;
    public void Subtract() => Result = Num1 - Num2;
    public void Multiply() => Result = Num1 * Num2;

    public void Divide()
    {
        Result = Num2 == 0 ? 0 : Num1 / Num2;
    }
}

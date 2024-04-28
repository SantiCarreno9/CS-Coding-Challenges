using System;

public class TextInput
{
    private string value = "";

    public virtual void Add(char character) => value += character;

    public string GetValue() { return value; }
}

public class NumericInput : TextInput
{
    public override void Add(char character)
    {
        if (Char.IsDigit(character))
            base.Add(character);
    }
}

public class UserInput
{
    //public static void Main(string[] args)
    //{
    //    TextInput input = new NumericInput();
    //    input.Add('1');
    //    input.Add('a');
    //    input.Add('0');
    //    Console.WriteLine(input.GetValue());
    //}
}
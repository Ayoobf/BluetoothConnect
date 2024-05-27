namespace BluetoothConnect.Commands;

public class AddCommand: CommandBase
{
    public AddCommand()
    {

    }

    public override void Execute(object? parameter)
    {
        Console.WriteLine("add");
    }
}
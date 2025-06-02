using MessagePack;

[MessagePackObject]
public class Rota
{
    [Key(0)]
    public string Name { get; set; }

    [Key(1)]
    public int Age { get; set; }

    [Key(2)]
    public string Greeting { get; set; }
}
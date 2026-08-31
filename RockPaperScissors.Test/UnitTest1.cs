namespace RockPaperScissors.Test;
using RockPaperScissors.Core;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        stateVector memoria = new stateVector(4);
        memoria.RecordMove(1);
        memoria.RecordMove(2);
        memoria.RecordMove(1);
        Assert.Equal("vector es: ", memoria.GetSerializedHistory());
    }
}
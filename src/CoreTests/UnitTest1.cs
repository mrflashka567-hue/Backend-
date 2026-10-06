using Core;

namespace CoreTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Location location = new Location()
        {
            Name = "                    ",
            Address = "       Test   ",
            CreatedAt = DateTime.Now,
            Id = Guid.NewGuid(),
            UpdatedAt = DateTime.Now,
            TimeZone = "Sweden/Stockholm",



        };


    }
}

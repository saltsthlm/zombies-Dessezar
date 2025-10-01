using Xunit;
using ZOMBIE_in_.NET;

namespace ZombieTest;

public class ZombiesTest

{
    [Fact]
    public void Empty_room_that_fits_one_zombie_is_not_full()
    {
        //Arrange
        var room = new Room(1);

        //Act
        var result = room.IsFull();

        //Assert
        Assert.False(result);
    }
}

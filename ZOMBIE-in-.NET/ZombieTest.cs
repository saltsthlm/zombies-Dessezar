namespace ZOMBIE_in_.NET;

public class ZombieTest
{

    [Fact]
    public void Empty_room_that_fits_one_zombie_is_not_full()
    {
        // Arrange
        var room = new Room(1);

        // Act
        var isRoomFull = room.IsFull();

        // Assert
        Assert.False(isRoomFull);
    }

}

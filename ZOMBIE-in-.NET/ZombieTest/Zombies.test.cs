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
        var result = room.IsFull(false);

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void room_with_no_capacity_cannot_fit_any_zombies()
    {
        //Arrange
        var room = new Room(0);

        //Act
        var result = room.IsFull(true);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void one_roomer_becomes_full_when_a_zombie_is_added()
    {
        //Arrange
        var room = new Room(1);
        Assert.False(room.IsFull(false));

        //Act
        var result = room.IsFull(true);
        room.AddZombie(new Zombie(1, DateTime.Now, room));

        //Assert
        Assert.True(result);
        Assert.Equal(1, room.currentZombies);
    }
}

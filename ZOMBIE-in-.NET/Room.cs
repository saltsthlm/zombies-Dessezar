namespace ZOMBIE_in_.NET;

public class Room
{
    private int capacity;
    private int currentZombies;

    public Room(int capacity)
    {
        this.capacity = capacity;
        this.currentZombies = 0;
    }

    public bool IsFull()
    {
        return currentZombies >= capacity;
    }

    

}

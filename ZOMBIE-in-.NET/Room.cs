namespace ZOMBIE_in_.NET;

public class Room
{
    private int capacity;
    public int currentZombies;

    public Room(int capacity)
    {
        this.capacity = capacity;
        this.currentZombies = 0;
    }

    public bool IsFull(bool v)
    {
        if (capacity <= 0)
        {
            return true;
        }
        return false;
    }

    public void AddZombie(Zombie zombie)
    {
        if (!IsFull(true))
        {
            currentZombies++;
        }
    }



}

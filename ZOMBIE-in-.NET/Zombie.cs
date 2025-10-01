namespace ZOMBIE_in_.NET;

public class Zombie
{
    private int id;
    private DateTime created = DateTime.Now;
    //kanske räcker med ett id, och en ++ för att veta vilekn zombie som är älst typ
    //typ if zombie.id < than zombie.id så är den äldst
    private Room Room;
    public Zombie(int id, DateTime created, Room room)
    {
        this.id = id;
        this.created = created;
        this.Room = room;

    }
    // atrubut så som Created, så att man kan ta bort den som skapades först. 
    //metod som consume för att ta bort den äldsta



    public void Consume(Zombie zombie)
    {
        if (created < DateTime.Now && Room.IsFull(true))
        {
            //ta bort den äldsta zombien
        }

    }
}


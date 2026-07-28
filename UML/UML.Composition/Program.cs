/*
    Composition
    - Strong has a relationship
    - If the parent object is destroyed, the child objects will also be destroyed
*/

internal record Room(string Name);
internal class House
{
    private List<Room> Rooms;

    public House()
    {
        Rooms = [new Room("Living Room"), new Room("Bedroom"), new Room("Kitchen")];
    }

    public void ShowRooms()
    {
        foreach (var room in Rooms)
        {
            Console.WriteLine(room.Name);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        House house = new House();
        house.ShowRooms();
    }
}

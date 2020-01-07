import java.util.List;

public class Hotel {

    private String name;
    private List<Room> rooms;

    public Hotel(String name, List<Room> rooms){
        this.name = name;
        this.rooms = rooms;
    }

    public Hotel(String name){
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public List<Room> getRooms() {
        return rooms;
    }

    public void addRoom(Room room){
        rooms.add(room);
    }

    public void addRooms(List<Room> rooms){
        rooms.addAll(rooms);
    }


}

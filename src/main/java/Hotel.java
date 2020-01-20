import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;
import java.util.List;

@XmlRootElement
public class Hotel {

    public String name;
    public List<Room> rooms = new ArrayList<Room>();

    public Hotel() {
    }

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
        this.rooms.addAll(rooms);
    }


}

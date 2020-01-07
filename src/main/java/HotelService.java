import javax.jws.WebMethod;
import javax.jws.WebService;
import java.util.ArrayList;
import java.util.List;

@WebService(targetNamespace = "http://localhost:9999/ws" )
public class HotelService {

    List<Hotel> hotels;

    public HotelService(List<Hotel> hotels){
        this.hotels = hotels;
    }

    public List<Hotel> getHotels() {
        return hotels;
    }

    public List<Room> getRoomsFor(Hotel hotel){
       return hotels.get(hotels.indexOf(hotel)).getRooms();
    }

    public void book(Room room){
        room.setAvailable(false);
    }

    public void cancelBooking(Room room){
        room.setAvailable(true);
    }

}

import javax.xml.ws.Endpoint;
import java.util.ArrayList;
import java.util.List;

public class Application {

    static private Hotels hotels;

    public static void main(String[] args) {

        createHotels();

        Endpoint endPoint = Endpoint.publish("http://localhost:9999/ws/hotels", hotels);

    }

    static public void createHotels(){
        List<Hotel> hotelsList = new ArrayList<Hotel>();

        Hotel bastienHotel = new Hotel("Bastien Hotel");
        hotelsList.add(bastienHotel);

        Hotel virginieHotel = new Hotel("Virginie Hotel");
        hotelsList.add(virginieHotel);

        Hotel louisHotel = new Hotel("Louis Hotel");
        hotelsList.add(louisHotel);

        Hotel alesHotel = new Hotel("Ales Hotel");
        hotelsList.add(alesHotel);

        for (Hotel hotel : hotelsList){
            hotel.addRooms(createRooms(1,Room.Category.SINGLE,90));
            hotel.addRooms(createRooms(5,Room.Category.DOUBLE,160));
            hotel.addRooms(createRooms(9,Room.Category.SUITE,200));
        }

        hotels = new Hotels(hotelsList);

    }

    private static List<Room> createRooms(int start, Room.Category category,float price) {
        List<Room> toReturn = new ArrayList<Room>();

        for (int i = start; i < 4; i++) {
            Room room = new Room(i,category,price);
            toReturn.add(room);
        }

        return toReturn;
    }
}

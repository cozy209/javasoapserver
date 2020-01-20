import javax.xml.ws.Endpoint;
import java.net.InetAddress;
import java.util.ArrayList;
import java.util.List;

public class Application {

    static private HotelService hotelService;

    public static void main(String[] args) throws Exception{

        hotelService = createHotels();

        InetAddress inetAddress = InetAddress.getLocalHost();

        Endpoint endPoint = Endpoint.publish("http://"+inetAddress.getHostAddress()+":9999/ws/hotels", hotelService);

        System.out.println("Service lancé");

    }

    static public HotelService createHotels(){
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
            hotel.addRooms(createRooms(6,Room.Category.DOUBLE,160));
            hotel.addRooms(createRooms(11,Room.Category.SUITE,200));
        }

        return new HotelService(hotelsList);

    }

    private static List<Room> createRooms(int start, Room.Category category,float price) {
        List<Room> toReturn = new ArrayList<Room>();

        for (int i = start; i < start+5; i++) {
            Room room = new Room(i,category,price);
            toReturn.add(room);
        }

        return toReturn;
    }
}

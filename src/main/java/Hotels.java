import javax.jws.WebMethod;
import javax.jws.WebService;
import java.util.ArrayList;
import java.util.List;

@WebService(targetNamespace = "http://localhost:9999/ws" )
public class Hotels {

    List<Hotel> hotels;

    public Hotels(List<Hotel> hotels){
        this.hotels = hotels;
    }

    @WebMethod
    public List<String> printValues(){
        List<String> toReturn = new ArrayList<String>();
        for (Hotel hotel : hotels){
            String hotelInfos = hotel.getName()+"\n";
            for (Room room : hotel.getRooms()){
                hotelInfos += room.getRoomNumber()+" - "+room.getCategory()+" - "+room.getAvailability()+" - "+room.getPrice()+"\n";
            }

            toReturn.add(hotelInfos);
        }
        return toReturn;
    }
}

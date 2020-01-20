import javax.jws.WebService;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class Room {

    public int roomNumber;
    public Category category;
    public boolean available = true;
    public float price;

    public Room(int roomNumber, Category category, float price){
        this.roomNumber = roomNumber;
        this.category = category;
        this.price = price;
    }

    public Room() {
    }

    public int getRoomNumber() {
        return roomNumber;
    }

    public Category getCategory(){
        return category;
    }

    public boolean getAvailability(){
        return available;
    }

    public void setAvailable(boolean isAvailable){
        this.available = isAvailable;
    }

    public float getPrice(){
        return price;
    }

    enum Category {
        SINGLE("Single"),
        DOUBLE("Double"),
        SUITE("Suite");

        public String category;

        Category(String category){
            this.category = category;
        }
    }

}

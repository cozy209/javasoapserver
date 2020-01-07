import javax.jws.WebService;

@WebService
public class Room {

    int roomNumber;
    Category category;
    boolean available = true;
    float price;

    public Room(int roomNumber, Category category, float price){
        this.roomNumber = roomNumber;
        this.category = category;
        this.price = price;
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

        private String category;

        Category(String category){
            this.category = category;
        }
    }

}

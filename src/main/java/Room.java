import javax.jws.WebService;

@WebService
public class Room {

    private int roomNumber;
    private Category category;
    private boolean available = true;
    private float price;

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

    public void bookRoom(){
        this.available = false;
    }

    public void checkOut(){
        this.available = true;
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

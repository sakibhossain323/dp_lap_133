package entity;

public class Driver {
    private int id;
    private String name;
    private String vehicleType;
    private String Location;
    private int rating;
    private Boolean available;

    public Driver() {
    }

    public Driver(int id, String name, String vehicleType, String location, int rating, Boolean available) {
        this.id = id;
        this.name = name;
        this.vehicleType = vehicleType;
        Location = location;
        this.rating = rating;
        this.available = available;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getVehicleType() {
        return vehicleType;
    }

    public void setVehicleType(String vehicleType) {
        this.vehicleType = vehicleType;
    }

    public String getLocation() {
        return Location;
    }

    public void setLocation(String location) {
        Location = location;
    }

    public int getRating() {
        return rating;
    }

    public void setRating(int rating) {
        this.rating = rating;
    }

    public Boolean getAvailable() {
        return available;
    }

    public void setAvailable(Boolean available) {
        this.available = available;
    }
}

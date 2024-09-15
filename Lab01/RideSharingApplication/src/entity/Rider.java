package entity;

public class Rider {
    private int id;
    private String name;
    private int rating;
    private String preferredPaymentMethod;

    public Rider() {
    }

    public Rider(int id, String name, int rating, String preferredPaymentMethod) {
        this.id = id;
        this.name = name;
        this.rating = rating;
        this.preferredPaymentMethod = preferredPaymentMethod;
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

    public int getRating() {
        return rating;
    }

    public void setRating(int rating) {
        this.rating = rating;
    }

    public String getPreferredPaymentMethod() {
        return preferredPaymentMethod;
    }

    public void setPreferredPaymentMethod(String preferredPaymentMethod) {
        this.preferredPaymentMethod = preferredPaymentMethod;
    }

    @Override
    public String toString() {
        return "Rider{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", rating=" + rating +
                ", preferredPaymentMethod='" + preferredPaymentMethod + '\'' +
                '}';
    }
}

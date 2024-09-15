package entity;

public abstract class RideType {
    private double baseFare;

    public RideType(double baseFare) {
        this.baseFare = baseFare;
    }

    public double getBaseFare() {
        return baseFare;
    }

    public void setBaseFare(double baseFare) {
        this.baseFare = baseFare;
    }
}

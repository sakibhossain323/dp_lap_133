package service.implementation;

import service.DriverService;
import service.TripService;

public class SimpleTripService implements TripService {
    private final DriverService driverService;

    public SimpleTripService(DriverService driverService) {
        this.driverService = driverService;
    }

    public void assignDriver() {
        System.out.println("Driver assigned");
    }

    public void calculateFare() {
        System.out.println("Fare calculated");
    }

    public void completeTrip() {
        System.out.println("Trip completed");
    }
}

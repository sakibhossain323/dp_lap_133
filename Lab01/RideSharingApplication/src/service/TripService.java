package service;

import entity.Driver;
import entity.Trip;

import java.util.List;

public interface TripService {
    void assignDriver();
    void calculateFare();
    void completeTrip();

    Trip createTrip(Trip trip);
}

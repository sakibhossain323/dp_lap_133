package service;

import entity.Driver;

import java.util.List;

public interface TripService {
    void assignDriver();
    void calculateFare();
    void completeTrip();
}

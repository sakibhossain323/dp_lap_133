package service;

import entity.Driver;
import entity.RideType;

import java.util.List;

public interface DriverService {
    void acceptRide();
    void rateRider();
    void updateLocation();
    void startTrip();
}

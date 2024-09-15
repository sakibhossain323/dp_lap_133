package service;

import entity.Driver;
import entity.RideType;

import java.util.List;

public interface DriverService {
    List<Driver> findAvailableDrivers(RideType rideType);
}

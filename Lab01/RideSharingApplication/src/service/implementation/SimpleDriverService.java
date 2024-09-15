package service.implementation;

import entity.Driver;
import entity.RideType;
import service.DriverService;

import java.util.List;

public class SimpleDriverService implements DriverService {

    @Override

    public List<Driver> findAvailableDrivers(RideType rideType) {
        return null;
    }
}

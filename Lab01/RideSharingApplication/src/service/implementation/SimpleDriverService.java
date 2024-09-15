package service.implementation;

import entity.Driver;
import repository.DriverRepository;
import service.DriverService;

public class SimpleDriverService implements DriverService {
    private final DriverRepository driverRepository;

    public SimpleDriverService(DriverRepository driverRepository) {
        this.driverRepository = driverRepository;
    }

    @Override
    public void acceptRide() {

    }

    @Override
    public void rateRider() {

    }

    @Override
    public void updateLocation() {

    }

    @Override
    public void startTrip() {

    }

    @Override
    public Driver createDriver(Driver driver) {
        return driverRepository.save(driver);
    }
}

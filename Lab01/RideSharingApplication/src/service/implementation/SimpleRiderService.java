package service.implementation;

import entity.RideType;
import entity.Rider;
import repository.RiderRepository;
import service.RiderService;
import service.TripService;

import java.util.List;

public class SimpleRiderService implements RiderService {
    private final RiderRepository riderRepository;

    public SimpleRiderService(RiderRepository riderRepository) {
        this.riderRepository = riderRepository;
    }

    @Override
    public void requestRide() {

    }

    @Override
    public Rider createRider(Rider rider) {
        return riderRepository.save(rider);
    }
}

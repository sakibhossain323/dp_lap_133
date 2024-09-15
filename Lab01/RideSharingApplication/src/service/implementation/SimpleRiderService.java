package service.implementation;

import entity.RideType;
import entity.Rider;
import service.RiderService;
import service.TripService;

import java.util.List;

public class SimpleRiderService implements RiderService {
    private final TripService tripService;

    public SimpleRiderService(TripService tripService) {
        this.tripService = tripService;
    }


    @Override
    public void requestRide(RideType rideType) {

    }
}

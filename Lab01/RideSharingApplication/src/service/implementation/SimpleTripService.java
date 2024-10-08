package service.implementation;

import entity.Trip;
import repository.TripRepository;
import service.TripService;

public class SimpleTripService implements TripService {
    private final TripRepository tripRepository;

    public SimpleTripService(TripRepository tripRepository) {
        this.tripRepository = tripRepository;
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

    @Override
    public Trip createTrip(Trip trip) {
        return tripRepository.save(trip);
    }
}

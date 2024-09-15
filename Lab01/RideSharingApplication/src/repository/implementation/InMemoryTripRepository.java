package repository.implementation;

import entity.Trip;
import repository.TripRepository;

import java.util.ArrayList;
import java.util.List;

public class InMemoryTripRepository implements TripRepository {
    private final List<Trip> trips;

    public InMemoryTripRepository() {
        trips = new ArrayList<>();
    }

    @Override
    public Trip save(Trip trip) {
        if(trip.getId() == 0) {
            int maxId = trips.stream()
                    .map(Trip::getId)
                    .max(Integer::compare)
                    .orElse(0);
            trip.setId(maxId + 1);
        }
        trips.add(trip);
        return trip;
    }

    @Override
    public Trip findById(int id) {
        return trips.stream()
                .filter(trip -> trip.getId() == id)
                .findFirst().orElse(null);
    }

    @Override
    public List<Trip> findAll() {
        return trips;
    }
}

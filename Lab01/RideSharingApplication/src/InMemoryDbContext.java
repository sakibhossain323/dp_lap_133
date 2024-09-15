import entity.Driver;
import repository.DriverRepository;
import repository.RiderRepository;
import repository.TripRepository;
import repository.implementation.InMemoryDriverRepository;
import repository.implementation.InMemoryRiderRepository;
import repository.implementation.InMemoryTripRepository;

import java.util.List;

public class InMemoryDbContext implements DbContext {
    private final RiderRepository riderRepository;
    private final DriverRepository driverRepository;
    private final TripRepository tripRepository;

    public InMemoryDbContext() {
        this.riderRepository = new InMemoryRiderRepository();
        this.driverRepository = new InMemoryDriverRepository();
        this.tripRepository = new InMemoryTripRepository();

        populateData();
    }

    @Override
    public RiderRepository getRiderRepository() {
        return riderRepository;
    }

    @Override
    public DriverRepository getDriverRepository() {
        return driverRepository;
    }

    @Override
    public TripRepository getTripRepository() {
        return tripRepository;
    }

    private void populateData() {
        List<Driver> drivers = List.of(
                new Driver(1, "Alice", "Car", "A", 5, true),
                new Driver(2, "Bob", "Car", "A", 4, false),
                new Driver(3, "Charlie", "Bike", "A", 5, true),
                new Driver(4, "David", "Bike", "A", 4, false),
                new Driver(5, "Eve", "Car", "B", 5, true),
                new Driver(6, "Frank", "Car", "B", 4, false),
                new Driver(7, "Grace", "Bike", "B", 5, true),
                new Driver(8, "Heidi", "Bike", "B", 4, false)
        );
        for(Driver driver : drivers) {
            driverRepository.save(driver);
        }

    }
}

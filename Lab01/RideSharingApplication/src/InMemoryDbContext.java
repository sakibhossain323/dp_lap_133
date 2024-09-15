import repository.DriverRepository;
import repository.RiderRepository;
import repository.TripRepository;
import repository.implementation.InMemoryDriverRepository;
import repository.implementation.InMemoryRiderRepository;
import repository.implementation.InMemoryTripRepository;

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

    }
}

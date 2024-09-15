import repository.DriverRepository;
import repository.RiderRepository;
import repository.TripRepository;

public interface DbContext {
    RiderRepository getRiderRepository();
    DriverRepository getDriverRepository();
    TripRepository getTripRepository();
}

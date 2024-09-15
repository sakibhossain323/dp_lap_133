import service.DriverService;
import service.RiderService;
import service.TripService;
import service.implementation.SimpleDriverService;
import service.implementation.SimpleRiderService;
import service.implementation.SimpleTripService;

import java.util.Scanner;

public class App {
    private final RiderService riderService;
    private final DriverService driverService;
    private final TripService tripService;

    public App(DbContext dbContext) {
        this.riderService = new SimpleRiderService(dbContext.getRiderRepository());
        this.driverService = new SimpleDriverService(dbContext.getDriverRepository());
        this.tripService = new SimpleTripService(dbContext.getTripRepository());
    }

    public void run()
    {
        boolean running = true;
        while(running)
        {
            Scanner scanner = new Scanner(System.in);
            int choice = scanner.nextInt();
            if(choice==0) running = false;
        }
    }
}

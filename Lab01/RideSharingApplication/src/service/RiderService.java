package service;

import entity.RideType;
import entity.Rider;

public interface RiderService {
    void requestRide();
    Rider createRider(Rider rider);
}

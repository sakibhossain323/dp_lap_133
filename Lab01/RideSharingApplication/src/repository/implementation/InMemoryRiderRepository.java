package repository.implementation;

import entity.Rider;
import repository.RiderRepository;

import java.util.ArrayList;
import java.util.List;

public class InMemoryRiderRepository implements RiderRepository {
    private final List<Rider> riders;

    public InMemoryRiderRepository() {
        riders = new ArrayList<>();
    }
    @Override
    public Rider save(Rider rider) {
        if(rider.getId()==0){
            int maxId = riders.stream()
                    .map(Rider::getId)
                    .max(Integer::compare)
                    .orElse(0);
            rider.setId(maxId + 1);
        }
        riders.add(rider);
        return rider;
    }

    @Override
    public Rider findById(int id) {
        return riders.stream()
                .filter(rider -> rider.getId() == id)
                .findFirst().orElse(null);
    }

    @Override
    public List<Rider> findAll() {
        return riders;
    }
}

package repository.implementation;

import entity.Driver;
import repository.DriverRepository;

import java.util.ArrayList;
import java.util.List;

public class InMemoryDriverRepository implements DriverRepository {
    private final List<Driver> drivers;

    public InMemoryDriverRepository() {
        drivers = new ArrayList<>();
    }

    @Override
    public Driver save(Driver driver) {
        if(driver.getId() == 0) {
            int maxId = drivers.stream()
                    .map(Driver::getId)
                    .max(Integer::compare)
                    .orElse(0);
            driver.setId(maxId + 1);
        }
        drivers.add(driver);
        return driver;
    }

    @Override
    public Driver findById(int id) {
        return drivers.stream()
                .filter(driver -> driver.getId() == id)
                .findFirst().orElse(null);
    }

    @Override
    public List<Driver> findAll() {
        return drivers;
    }
}

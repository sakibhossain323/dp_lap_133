package repository;

import java.util.List;

public interface Repository<T> {
    T save(T entity);
    T findById(int id);
    List<T> findAll();
}

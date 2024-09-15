public class Main {
    public static void main(String[] args) {
        DbContext dbContext = new InMemoryDbContext();
        App app = new App(dbContext);
        app.run();
    }
}
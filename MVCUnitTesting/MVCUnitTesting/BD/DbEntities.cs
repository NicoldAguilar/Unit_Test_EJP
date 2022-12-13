namespace MVCUnitTesting.BD
{
    public interface IDbEntities
    {
        //Métodos

    }
    public class DBEntities: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}

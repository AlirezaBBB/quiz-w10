namespace quiz_w10.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> getUsers();
    }
}

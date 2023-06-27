namespace quiz_w10.Repository
{
    public class UserRepository : IUserRepository
    {
        IEnumerable<User> IUserRepository.getUsers()
        {
            return DataBase.users;
        }
    }
}

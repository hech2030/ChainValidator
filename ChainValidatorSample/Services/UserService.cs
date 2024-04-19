namespace ChainValidatorSample.Services
{
    internal class UserService : IUserService
    {
        public async Task<bool> UserExist(string email, CancellationToken cancellationToken)
        {
            await Task.Delay(1000, cancellationToken); // cloning process
            return false;
        }
    }
}

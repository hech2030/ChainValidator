namespace ChainValidatorSample.Services
{
    internal interface IUserService
    {
        Task<bool> UserExist(string email, CancellationToken cancellationToken);
    }
}

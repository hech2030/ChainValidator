using ChainValidator.Validator;
using ChainValidatorSample.Services;

namespace ChainValidatorSample.UserValidator
{
    internal class IsExistingUser(IUserService userService) : CustomValidatorAsync<AddUserRequest, bool>
    {
        ////private readonly IUserService userService;
        private const string ErrorMessage = "User exists with same email address";

        public override async Task<ValidatorResult<bool>> ValidateAsync(AddUserRequest addUserRequest, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(addUserRequest);

            if (await userService.UserExist(addUserRequest.User.Email, cancellationToken))
            {
                return ValidatorResult<bool>.CreateError(ErrorMessage);
            }
            return await base.ValidateAsync(addUserRequest, cancellationToken);
        }
    }
}
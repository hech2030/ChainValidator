using ChainValidator.Validator;
using ChainValidatorSample.Services;

namespace ChainValidatorSample.UserValidator
{
    internal class AddUserRequestValidator : IConfigureValidatorAsync<AddUserRequest, Task<ValidatorResult<bool>>>
    {
        private readonly CustomValidatorAsync<AddUserRequest, bool> addUserRequestValidator;
        public AddUserRequestValidator(IUserService userService)
        {
            addUserRequestValidator = new ValidatorChainBuilderAsync<AddUserRequest, bool>()
                .Add(new IsExistingUser(userService))
                .Add(new IsHavingValidEmail())
                .Add(new IsHavingValidPassword())
                .GetFirst();
        }

        public Task<ValidatorResult<bool>> ValidateConfigureAsync(AddUserRequest validatorRequest, CancellationToken cancellationToken)
        {
            return addUserRequestValidator.ValidateAsync(validatorRequest, cancellationToken);
        }
    }
}

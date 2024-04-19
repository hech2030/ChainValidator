using ChainValidator.Validator;
using System.ComponentModel.DataAnnotations;

namespace ChainValidatorSample.UserValidator
{
    internal class IsHavingValidEmail : CustomValidatorAsync<AddUserRequest, bool>
    {
        private const string ErrorMessage = "Please provide a valid email address";
        public override async Task<ValidatorResult<bool>> ValidateAsync(AddUserRequest addUserRequest, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(addUserRequest);

            if (new EmailAddressAttribute().IsValid(addUserRequest.User.Email))
            {
                return ValidatorResult<bool>.CreateError(ErrorMessage);
            }
            return await base.ValidateAsync(addUserRequest, cancellationToken);
        }
    }
}
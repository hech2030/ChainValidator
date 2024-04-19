using ChainValidator.Validator;
using System.Text.RegularExpressions;

namespace ChainValidatorSample.UserValidator
{
    internal partial class IsHavingValidPassword : CustomValidatorAsync<AddUserRequest, bool>
    {
        private const string ErrorMessage = "The password provided should have at least one special caracter";

        public override async Task<ValidatorResult<bool>> ValidateAsync(AddUserRequest addUserRequest, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(addUserRequest);

            if (!HaveSpecialCaracter().IsMatch(addUserRequest.User.Password))
            {
                return ValidatorResult<bool>.CreateError(ErrorMessage);
            }
            return await base.ValidateAsync(addUserRequest, cancellationToken);
        }

        [GeneratedRegex("[^a-z0-9]")]
        private static partial Regex HaveSpecialCaracter();
    }
}
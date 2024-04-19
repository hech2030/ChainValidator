using System.Threading;
using System.Threading.Tasks;

namespace ChainValidator.Validator
{
    public class CustomValidatorAsync<input, result>
    {
        private CustomValidatorAsync<input, result> nextValidator;

        public async virtual Task<ValidatorResult<result>> ValidateAsync(input value, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (nextValidator != null)
            {
                return await nextValidator.ValidateAsync(value, cancellationToken);
            }
            return ValidatorResult<result>.CreateSuccess();
        }

        public void SetNextValidator(CustomValidatorAsync<input, result> validator)
        {
            nextValidator = validator;
        }
    }
}

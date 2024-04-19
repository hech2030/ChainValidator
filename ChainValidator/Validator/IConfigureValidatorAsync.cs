using System.Threading;

namespace ChainValidator.Validator
{
    public interface IConfigureValidatorAsync<in input, out output>
    {
        output ValidateConfigureAsync(input validatorRequest, CancellationToken cancellationToken);
    }
}

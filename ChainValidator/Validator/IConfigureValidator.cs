namespace ChainValidator.Validator
{
    public interface IConfigureValidator<in input, out output>
    {
        output ValidateConfigure(input validatorRequest);
    }
}

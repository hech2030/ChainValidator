namespace ChainValidator.Validator
{
    public class ValidatorChainBuilderAsync<input, result>
    {
        private CustomValidatorAsync<input, result> first;
        private CustomValidatorAsync<input, result> last;

        public ValidatorChainBuilderAsync<input, result> Add(CustomValidatorAsync<input, result> validator)
        {
            if (first == null)
            {
                first = validator;
            }
            else
            {
                last.SetNextValidator(validator);
            }
            last = validator;
            return this;
        }

        public CustomValidatorAsync<input, result> GetFirst()
        {
            return first;
        }
    }
}

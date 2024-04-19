namespace ChainValidator.Validator
{
    public class ValidatorChainBuilder<input, result>
    {
        private CustomValidator<input, result> first;
        private CustomValidator<input, result> last;

        public ValidatorChainBuilder<input, result> Add(CustomValidator<input, result> validator)
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

        public CustomValidator<input, result> GetFirst()
        {
            return first;
        }
    }
}

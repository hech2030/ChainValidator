namespace ChainValidator.Validator
{
    public class CustomValidator<input, result>
    {
        private CustomValidator<input, result> nextValidator;

        public virtual ValidatorResult<result> Validate(input value)
        {
            if (nextValidator != null)
            {
                return nextValidator.Validate(value);
            }
            return ValidatorResult<result>.CreateSuccess();
        }

        public void SetNextValidator(CustomValidator<input, result> validator)
        {
            nextValidator = validator;
        }
    }
}

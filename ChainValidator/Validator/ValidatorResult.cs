namespace ChainValidator.Validator
{
    public class ValidatorResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Value { get; set; }
        public string Message { get; set; }

        public static ValidatorResult<T> CreateError(string message) => CreateError(message, default);

        public static ValidatorResult<T> CreateError(string message, T value)
        {
            return new ValidatorResult<T>
            {
                IsSuccess = false,
                Message = message,
                Value = value
            };
        }

        public static ValidatorResult<T> CreateSuccess()
        {
            return new ValidatorResult<T>
            {
                IsSuccess = true,
            };
        }
    }
}

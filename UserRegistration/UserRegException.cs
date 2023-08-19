namespace UserRegistration
{
    public class UserRegException : Exception
    {
        public ExceptionType exceptionType;

        public enum ExceptionType
        {
            INVALID_MESSAGE,
            EMPTY_MESSAGE
        }
        public UserRegException(ExceptionType exceptionType, string massage) : base(massage)
        {
            this.exceptionType = exceptionType;
        }
    }
}

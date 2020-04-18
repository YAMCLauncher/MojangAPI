namespace MojangApi.Responses
{
    public class ErrorResponse
    {
        public string Error { get; }
        public string ErrorMessage { get; }
        public string Cause { get; }
        
        public ErrorResponse(string error, string errorMessage, string cause)
        {
            this.Error = error;
            this.ErrorMessage = errorMessage;
            this.Cause = cause;
        }
    }
}
namespace LocationApp.Shared
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public void Fail(string message)
        {
            IsSuccess = false;
            Message = message;
        }

        public void Success(string message = null)
        {
            IsSuccess = true;

            if (!string.IsNullOrEmpty(message))
            {
                Message = message;
            }
        }
    }
}

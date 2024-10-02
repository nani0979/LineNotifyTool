namespace LineNotifyTool.Services
{
    public class ResponseCodeService
    {
        public ResponseCodeService() 
        {
        }

        public ErrorCode ConnectSucessfully() 
        {
            return new ErrorCode(100, "Connect successfully.");
        }
    }

    public class ErrorCode
    {
        public ErrorCode(int code, string message)
        {
            this.code = code;
            this.message = message;
        }
        public int code { get; set; }
        public string message { get; set; }
        //public ErrorCode() { code = 0; message = ""; }
        //public object? data { get; set; }
    }
}

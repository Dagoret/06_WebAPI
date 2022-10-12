namespace _06_WebAPI.Models
{
    public class StatusCodeResultPers
    {
        public string StatusCodePers( int code)
        {
            return ErrorMessage(code);
        }

        public string ErrorMessage(int num)
        {
            switch (num)
            {
                case 0:
                    return "errore 0";
                default:
                    return "";
            }
        }


    }
}

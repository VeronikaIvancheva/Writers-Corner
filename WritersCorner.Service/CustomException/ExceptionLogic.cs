
namespace WritersCorner.Service.CustomException
{
    public class ExceptionLogic : System.Exception
    {
        public ExceptionLogic()
        {

        }

        public ExceptionLogic(string message)
            : base(message)
        {

        }
    }
}

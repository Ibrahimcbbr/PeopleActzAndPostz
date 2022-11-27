namespace PeopleActzAndPostz.Domain.Common.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string error):base(error)
        {
       
        }
    }
}

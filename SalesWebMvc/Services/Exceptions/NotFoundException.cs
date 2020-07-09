using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        //Ao termos excepções personalizadas teremos um controlo maior de como tratar as que podem ocorrer
        public NotFoundException(string message) : base(message)
        {
            
        }
    }
}

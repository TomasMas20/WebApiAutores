using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiAutores.Filtros
{
    public class FIltroDeExcepcion: ExceptionFilterAttribute
    {
        private readonly ILogger<FIltroDeExcepcion> logger;

        public FIltroDeExcepcion(ILogger<FIltroDeExcepcion> logger)
        {
            this.logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception, context.Exception.Message);

            base.OnException(context);  
        }
    }
}

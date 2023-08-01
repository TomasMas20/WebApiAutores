namespace WebApiAutores.DTO
{
    public class CollecionDeRecursos<T>: Recurso where T: Recurso
    {
        public List<T> Valores { get; set; }
    }
}

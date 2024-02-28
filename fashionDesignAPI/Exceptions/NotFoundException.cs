namespace fashionDesignAPI.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string mensagem)
            : base(mensagem) { }
    }
}

namespace fashionDesign.Exceptions
{
    public class ConflictException : Exception
    {
        public ConflictException(string mensagem)
            : base(mensagem) { }
    }
}

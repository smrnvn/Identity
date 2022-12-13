namespace Identity.BLL.Infrastructure
{
    public interface IEncryptation
    {
        public string ToEncrypte(string value);
        public string UnEncrypte(string value);
    }
}

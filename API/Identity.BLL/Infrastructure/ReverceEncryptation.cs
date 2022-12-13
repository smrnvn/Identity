namespace Identity.BLL.Infrastructure
{
    public class ReverceEncryptation : IEncryptation
    {      
        public string ToEncrypte(string value)
        {
            var result = string.Empty;
            for(var i = value.Length-1; i >= 0; i--)
            {
                result += value[i];
            }

            return result;
        }
        public string UnEncrypte(string value)
        {
            return ToEncrypte(value);
        }
    }
}

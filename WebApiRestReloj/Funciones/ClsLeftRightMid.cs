namespace WebApiRestReloj
{
    public class ClsLeftRightMid
    {
        public static string Left(string param, int length)
        {

            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {

            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        public static string Mid(string param, int startIndex)
        {
            string result = param.Substring(startIndex);
            return result;
        }
        public static string MidD(string param, int startIndex, int length)
        {
            string result = "";
            if (param.Length > startIndex)
            {
                result = param.Substring(startIndex, length);
            }
            else
            {
                result = "";
            }
            return result;
        }
    }
}

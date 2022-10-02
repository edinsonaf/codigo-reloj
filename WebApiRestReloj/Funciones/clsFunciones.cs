namespace WebApiRestReloj
{
    public class clsFunciones
    {
        public string StrZero(int inumero, int izeros)
        {
            string s = "";

            for (int x = 1; x < izeros; x++)
            {
                s = s + "0";
            }
            string resp = ClsLeftRightMid.Right(s + inumero, izeros);
            return resp;

        }
    }
}

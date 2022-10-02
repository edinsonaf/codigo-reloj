using System.Data;
using System.Reflection;
using ZKSoftwareAPI;

namespace WebApiRestReloj
{
    public class Masistencia
    {
        public List<ReporteAsistencia> nreporte(string cboreloj)
        {
            clsFunciones func = new clsFunciones();
            ZKSoftware dispositivo = new ZKSoftware(Modelo.X628C);

            DataTable dt;
            try
            {
                if (!dispositivo.DispositivoConectar(cboreloj.Trim(), 1, true))
                {
                    //MessageBox.Show(dispositivo.ERROR);
                }

                dt = new DataTable();
                List<ReporteAsistencia> rptais = new List<ReporteAsistencia>();
                string[] strlist;
                char[] listax = new char[] { '|', ' ' };
                dispositivo.DispositivoObtenerRegistrosAsistencias();
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("TARJETA"), new DataColumn("FECHA"), new DataColumn("HORA") });

                int p = 1;

                do
                {
                    strlist = dispositivo.ListaMarcajes[p].ToString().Split(listax, StringSplitOptions.RemoveEmptyEntries);
                    rptais.Add(new ReporteAsistencia
                    {
                        TARJETA = func.StrZero(Convert.ToInt32(strlist[0]), 5),
                        FECHA = strlist[1],
                        HORA = Convert.ToDateTime(strlist[2]).ToString("HH:mm:ss")

                    });

                    p++;

                } while (p < dispositivo.ListaMarcajes.Count);

                return rptais;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

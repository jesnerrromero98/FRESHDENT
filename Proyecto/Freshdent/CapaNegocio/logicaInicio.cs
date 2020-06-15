using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;//Referencia
using CapaEntidades;//Referencia


namespace CapaNegocio
{
    public class logicaInicio
    {
        InicioSesion Inic = new InicioSesion();//Instancia


        //Regresa lo que devuelve cada método
        public int insertarCita(Inicio ct)
        {
            return Inic.insertarinicio(ct);
        }
        public List<Inicio> listarCita()
        {
            return Inic.listarInicio();
        }

        public Inicio IniciarSesion(string LoginName, string Password)
        {
            return Inic.iniciarSesion(LoginName, Password);
        }
    }
}

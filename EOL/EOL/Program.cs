using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOL
{
    class Program
    {
        #region Variables Globales
        string _NomUsuari = "";
        const string _cNom_Complert = "Nom Complert";
        const string _cEmail = "Correu Electronic";
        const string _cTelf = "Telefon";
        const string _cAdreca = "Adreca";
        const string _cContraseña = "Paraula Clau";
        string _Nom_Complert = "";
        string _Email = "";
        string _Telf = "";
        string _Adreca = "";
        string _Contraseña = "";
        Dictionary<string, string> _dDatos = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, string>> _DG = new Dictionary<string, Dictionary<string, string>>();       
        #endregion

        static void Main(string[] args)
        {

        }

        #region Preguntas
        private void PreguntasGenerales()
        {

        }
        private void PreguntasAñadir()
        {

        }
        private void PreguntasBorrar()
        {

        }
        private void PreguntasModificar()
        {

        }
        #endregion

        private void LLenarDiccionario()
        {
            _dDatos.Add(_cNom_Complert, _Nom_Complert);
            _dDatos.Add(_cEmail, _Email);
            _dDatos.Add(_cTelf, _Telf);
            _dDatos.Add(_cAdreca, _Adreca);
            _dDatos.Add(_cContraseña, _Contraseña);

            _DG.Add(_NomUsuari, _dDatos);
        }
    }
}

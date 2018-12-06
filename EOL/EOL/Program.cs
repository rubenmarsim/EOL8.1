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
        static string _OpcionGeneral = "";
        static string _NomUsuari = "";
        const string _cNomComplert = "Nom Complert";
        const string _cEmail = "Correu Electronic";
        const string _cTelf = "Telefon";
        const string _cAdreca = "Adreca";
        const string _cContraseña = "Paraula Clau";
        static string _Nom_Complert = "";
        static string _Email = "";
        static string _Telf = "";
        static string _Adreca = "";
        static string _Contraseña = "";
        static bool _SiExisteUsuario = false;
        static Dictionary<string, string> _dDatos = new Dictionary<string, string>();
        static Dictionary<string, Dictionary<string, string>> _DG = new Dictionary<string, Dictionary<string, string>>();       
        #endregion

        static void Main(string[] args)
        {
            PreguntasGenerales();
            Console.ReadKey();            
        }

        #region Preguntas
        private static void PreguntasGenerales()
        {
            Console.WriteLine("Escull opcio A per Afegir, E per Esborrar i M per Modificar");
            _OpcionGeneral = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("Escriu el Nom d'Usuari");
            _NomUsuari = Console.ReadLine().Trim();
            if (_DG.ContainsKey(_NomUsuari))
            {
                _SiExisteUsuario = true;
            }
            else
            {
                _SiExisteUsuario = false;
            }

            if (_OpcionGeneral.Equals("A"))
            {
                if (!_SiExisteUsuario)
                {
                    PreguntasAñadir();
                }
                else
                {
                    Console.WriteLine("L'Usuari ja existeix, proba amb un altre");
                }                
            }
            else if (_OpcionGeneral.Equals("E"))
            {
                if (_SiExisteUsuario)
                {
                    PreguntasBorrar();
                }
                else
                {
                    Console.WriteLine("L'Usuari no existeix, proba amb un altre");
                }                
            }
            else if (_OpcionGeneral.Equals("M"))
            {
                if (_SiExisteUsuario)
                {
                    PreguntasModificar();
                }
                else
                {
                    Console.WriteLine("L'Usuari no existeix, proba amb un altre");
                }
            }
            else
            {
                Console.WriteLine("Introdueix una opcio valida");
            }
        }
        private static void PreguntasAñadir()
        {
            Console.WriteLine("Introdueix el "+_cNomComplert);
            _Nom_Complert = Console.ReadLine().Trim();
            Console.WriteLine("Introdueix el " + _cEmail);
            _Email = Console.ReadLine().Trim();
            Console.WriteLine("Introdueix el " + _cTelf);
            _Telf = Console.ReadLine().Trim();
            Console.WriteLine("Introdueix la " + _cAdreca);
            _Adreca = Console.ReadLine().Trim();
            Console.WriteLine("Introdueix la " + _cContraseña);
            _Contraseña = Console.ReadLine().Trim();

            LLenarDiccionario();
        }
        private static void PreguntasBorrar()
        {
            _DG.Remove(_NomUsuari);
        }
        private static void PreguntasModificar()
        {
            Console.WriteLine("Introdueix el " + _cNomComplert);
            _Nom_Complert = Console.ReadLine().Trim();
            Console.WriteLine("Introdueix el " + _cEmail);
            _Email = Console.ReadLine().Trim();
            Console.WriteLine("Introdueix el " + _cTelf);
            _Telf = Console.ReadLine().Trim();
            Console.WriteLine("Introdueix la " + _cAdreca);
            _Adreca = Console.ReadLine().Trim();
            Console.WriteLine("Introdueix la " + _cContraseña);
            _Contraseña = Console.ReadLine().Trim();

            LLenarDiccionario();
        }
        #endregion

        private static void LLenarDiccionario()
        {
            _dDatos.Add(_cNomComplert, _Nom_Complert);
            _dDatos.Add(_cEmail, _Email);
            _dDatos.Add(_cTelf, _Telf);
            _dDatos.Add(_cAdreca, _Adreca);
            _dDatos.Add(_cContraseña, _Contraseña);

            _DG.Add(_NomUsuari, _dDatos);
        }

        #region Gestion Datos
        private static void GuardarenDisco()
        {

        }
        private static void LeerdeDisco()
        {

        }
        #endregion
    }
}

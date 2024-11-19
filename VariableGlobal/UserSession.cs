using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    //publica (para todos poderem utilizar) 
    //estátia ( para todos utilizarem a mesma classe)
    public static class UserSession
    {
        //As variaveis que vão guardar as informações do usuário logado
        private static  string _usuario = null;
        private static string _senha = null;
        private static string _nome = null;

        //Encapsulei a váriavel para ter controle 
        //do que será inserido ou pego
        public static string usuario
        {
            get { return _usuario; }
            set { 
                //value = value.ToUpper();
                _usuario = value;
            }
        }

        public static string senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
            }
        }

        public static string nome
        {
            get { return _nome; }
            set
            {
                value = value.ToUpper();
                _nome = value;
            }
        }

    }
}

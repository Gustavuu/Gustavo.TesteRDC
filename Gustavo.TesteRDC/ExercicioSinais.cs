using System;

namespace Gustavo.TesteRDC
{
    public class ExercicioSinais
    {
        public bool ParesCombinados(string expressao)
        {
            bool retorno;
            if (expressao.Length > 1)
                retorno = (expressao.IndexOf("()") >= 0 || 
                           expressao.IndexOf("[]") >= 0 || 
                           expressao.IndexOf("{}") >= 0) &&
                             ParesCombinados(expressao.Replace("()", "").Replace("[]", "").Replace("{}", ""));
            else if (expressao.Length == 1)
                retorno = false;
            else
                retorno = true;
            return retorno;
        }
    }
}

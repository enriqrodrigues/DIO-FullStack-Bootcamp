namespace exemplo_construtores.Models
{
    public class Log
    {
        private static Log _log;

        public string PropriedadeLog { get; set; }
        private Log()   //como o construtor é privado, a classe não pode ser instanciada.;
        {
        }

        public static Log GetInstance()
        {
            if (_log == null)
            {
                _log = new Log();
            }
            return _log;
        }
    }
}

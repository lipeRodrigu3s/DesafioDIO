namespace ExemploConstrutores.Models
{
    public class log
    {
        private static log _log;


        private log()
        {
            
        }

        public static log GetInstance()
        {
            if (_log == null)
            {
                _log = new log();
            }
            return _log;
        }



    }
}
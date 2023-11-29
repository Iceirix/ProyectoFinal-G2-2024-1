using System;


namespace BiblioExpedientes
{
    public class Medico : Usuario
    {
        #region atributos
        private string nombre;
        #endregion

        public string Nombre { get => nombre; set => nombre = value; }

        public Medico(string user, string password, string nombre)
        {
            User = user;
            Password = password;
            Nombre = nombre;
        }

        
    }
}

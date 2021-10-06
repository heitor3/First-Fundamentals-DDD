using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> Notifications;


        public bool ValidarPropiedadeString(string valor, string nomePropiedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropiedade))
            {
                Notifications.Add(new Notifies
                {

                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropiedade

                });

                return false;
            }

            return true;
        }

        public bool ValidarPropiedadeInt(int valor, string nomePropiedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropiedade))
            {
                Notifications.Add(new Notifies
                {

                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = "nomePropiedade"

                });

                return false;
            }

            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.core.common
{
    public class Enums
    {

        public enum Role
        {
            Jefatura = 1,
            Empleado = 2
        }

        public enum EstadoTarea
        {
            Pendiente = 1,
            EnProgreso = 2,
            Finalizado = 3
        }

    }
}

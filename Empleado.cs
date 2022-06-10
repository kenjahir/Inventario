using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    //Clase padre empleado y cualidades.
    class Cliente : IMetodos
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string correo { get; set; }
        public int confirmacion { get; set; }

        //Metodo polimorfico mostrar datos 
        public virtual void Mostrar()
        {
            Console.WriteLine("Usuario: " + usuario + "\nCorreo: " + correo + "\nContraseña: **********" + "\nConfirmacion: " + confirmacion);
        }
    }

    public class empleado
    {
        public int usuario
        {
            get => default;
            set
            {
            }
        }

        public int contraseña
        {
            get => default;
            set
            {
            }
        }

        public int correo
        {
            get => default;
            set
            {
            }
        }

        public int confirmacion
        {
            get => default;
            set
            {
            }
        }
    }
}
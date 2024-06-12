using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_1105.Logica.Materiales
{
    public class Material
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }

        public Material(string id, string nombre, string unidad, decimal valorUnitario, bool estado, DateTime fechaCreacion, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Unidad = unidad;
            ValorUnitario = valorUnitario;
            Estado = estado;
            FechaCreacion = fechaCreacion;
            Descripcion = descripcion;
        }//definicion de los atributosa y constructor 
        //metodos pasar a una clase solo para generar llaves.
        public static string GenerarId() //Generar la id aleatoria
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder id = new StringBuilder("M-"); //pasar valor a parametro
            for (int i = 0; i < 12; i++)
            {
                id.Append(chars[new Random().Next(chars.Length)]);
            }
            return id.ToString();
        }

        //Función para crear un material
        public static (string mensaje, Material material) CrearMaterial(string nombre, string unidad, string valorUnitarioText, bool estado, string descripcion)
        {
            // Validar datos de entrada
            string mensajeError = "";

            if (nombre.Length < 5 || nombre.Length > 30)
            {
                mensajeError += "El nombre del material debe tener entre 5 y 30 caracteres.\n";
            }

            if (descripcion.Length > 1000)
            {
                mensajeError += "La descripción debe tener hasta 1000 caracteres.\n";
            }

            decimal valorUnitario;
            if (!decimal.TryParse(valorUnitarioText, NumberStyles.Number, CultureInfo.InvariantCulture, out valorUnitario) || valorUnitario <= 0)
            {
                mensajeError += "El valor unitario debe ser un número decimal positivo.\n";
            }
            else if (valorUnitario > 100000)
            {
                mensajeError += "El valor unitario debe estar entre 0 y 100 000.\n";
            }



            if (string.IsNullOrEmpty(unidad))
            {
                mensajeError += "La unidad no puede estar vacía.\n";
            }

            // Si hay errores, devolver mensaje y material nulo
            if (!string.IsNullOrEmpty(mensajeError))
            {
                return (mensajeError, null);
            }

            // Generar identificador único
            string id = GenerarId();

            // Crear objeto Material
            Material material = new Material(id, nombre, unidad, valorUnitario, estado, DateTime.Now, descripcion);
            return (mensajeError, material);
        }
    }

}

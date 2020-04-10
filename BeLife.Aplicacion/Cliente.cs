using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Aplicacion
{
    class Cliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int rut { get; set; }
        public string dv { get; set; }
        public DateTime fechaNac { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }

        public Cliente()
        {
            this.Init();
        }

        private void Init()
        {
            rut = 0;
            dv = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
            sexo = string.Empty;
            estadoCivil = string.Empty;
        }

        public bool Create()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();

            Datos.Cliente clien = new Datos.Cliente();

            try
            {
                CommonBC.Syncronize(this, clien);

                bbdd.Cliente.Add(clien);
                bbdd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                bbdd.Cliente.Remove();
                return false;
            }
        }

        public bool Update()
        {
            return true;
        }

        public bool Read()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }
    }
}

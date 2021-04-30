using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCorePracticaAWS.Models {
    [Table("coches")]
    public class Coche {

        [Key]
        [Column("idcoche")]
        public int IdCoche { get; set; }

        [Column("marca")]
        public String Marca { get; set; }

        [Column("modelo")]
        public String Modelo { get; set; }

        [Column("conductor")]
        public String Conductor { get; set; }

        [Column("imagen")]
        public String Imagen { get; set; }

        public Coche () { }

        public Coche (int idCoche, string marca, string modelo, 
            string conductor, string imagen) {
            IdCoche = idCoche;
            Marca = marca;
            Modelo = modelo;
            Conductor = conductor;
            Imagen = imagen;
        }
    }
}

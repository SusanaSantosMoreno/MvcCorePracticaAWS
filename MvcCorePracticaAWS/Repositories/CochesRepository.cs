using MvcCorePracticaAWS.Data;
using MvcCorePracticaAWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCorePracticaAWS.Repositories {
    public class CochesRepository {

        public CochesContext context;

        public CochesRepository(CochesContext context) { this.context = context; }

        public List<Coche> GetCoches () {
            return this.context.Coches.ToList();
        }

        public Coche GetCoche(int idCoche) {
            return this.context.Coches.SingleOrDefault(x => x.IdCoche == idCoche);
        }
    }
}

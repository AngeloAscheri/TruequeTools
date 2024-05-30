﻿using TruequeTools.Entities;

/*
 
Esta clase define los servicios que ofrece la entidad "Oferta"

 */

namespace TruequeTools.Services
{
    public interface IServiciosOferta
    {
        public Task CreateOferta(Oferta oferta);
        public Task<List<Oferta>> ReadAllOfertas();
        public Task<List<Oferta>> ReadAllOfertasRealizadasByUser(int userId);
        public Task<Oferta> OverwriteOfertaById(Oferta oferta);
        public Task RechazarOfertas(int publicacionId);
    }
}

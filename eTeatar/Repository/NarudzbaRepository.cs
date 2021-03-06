﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTransferObjects.Requests;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class NarudzbaRepository : Repository<Models.Narudzba, DataTransferObjects.Requests.NarudzbaSearchRequest>
    {
        public NarudzbaRepository(eTeatarContext context) : base(context)
        {
        }

        public override IEnumerable<Narudzba> Get(NarudzbaSearchRequest search)
        {
            var query = Context.Narudzba.AsQueryable();
            //Ime
            if (!string.IsNullOrEmpty(search?.Ime))
                query = query.Where(w => w.Kupac.KorisnickiNalog.Ime.ToUpper().Contains(search.Ime.ToUpper()));

            //Prezime
            if (!string.IsNullOrEmpty(search?.Prezime))
                query = query.Where(w => w.Kupac.KorisnickiNalog.Prezime.ToUpper().Contains(search.Prezime.ToUpper()));

            //Korisnicko Ime
            if (!string.IsNullOrEmpty(search?.KorisnickoIme))
                query = query.Where(w => w.Kupac.KorisnickiNalog.KorisnickoIme.ToUpper().Contains(search.KorisnickoIme.ToUpper()));

            //KupacId
            if (!string.IsNullOrEmpty(search?.KupacId))
                query = query.Where(w => w.Kupac.Id==search.KupacId);

            //Naziv predstave
            if (!string.IsNullOrEmpty(search?.NazivPredstave))
                query = query.Where(w => w.Termin.Predstava.Naziv.ToUpper().Contains(search.NazivPredstave.ToUpper()));

            query = query.Include(i => i.Termin).Include(i => i.Termin.Predstava).Include(i => i.Termin.Dvorana).ThenInclude(d => d.Teatar).Include(i=>i.TipSjedista).Include(i=>i.Ocjena);


            var list = query.ToList();
            foreach (var item in list)
            {
                item.Termin.Narudzbe = null;
                item.Termin.Dvorana.Teatar.Grad = Context.Grad.Where(w => w.Id == item.Termin.Dvorana.Teatar.GradId).FirstOrDefault();
            }
            return list;
        }

        public override Narudzba GetById(string id)
        {
            return Context.Narudzba.Include(i => i.Termin).Include(i => i.Termin.Predstava).Include(i => i.Termin.Dvorana).ThenInclude(d => d.Teatar).Include(i => i.Ocjena).FirstOrDefault(w => w.Id == id);
        }
    }
}

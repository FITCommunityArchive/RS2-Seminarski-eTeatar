﻿using DataTransferObjects.Requests;
using Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class KorisnickiNalogRepository : Repository<Models.KorisnickiNalog, KorisnickiNalogSearchRequest>, IKorisnickiNalogRepository
    {
        public KorisnickiNalogRepository(eTeatarContext context) : base(context)
        {
        }

        public override KorisnickiNalog Add(KorisnickiNalog obj)
        {
            //ValidacijaKorisnickogImena(obj.KorisnickoIme);
            obj.DatumKreiranja = DateTime.Now;
            return base.Add(obj);
        }

        public override IEnumerable<KorisnickiNalog> Get(KorisnickiNalogSearchRequest search)
        {
            IQueryable<KorisnickiNalog> query = Context.KorisnickiNalog.AsQueryable();

            if (!string.IsNullOrEmpty(search.Ime))
                query = Context.KorisnickiNalog.Where(k => k.Ime.ToUpper().Contains(search.Ime.ToUpper()));

            if (!string.IsNullOrEmpty(search.Prezime))
                query = Context.KorisnickiNalog.Where(k => k.Prezime.ToUpper().Contains(search.Prezime.ToUpper()));

            if (!string.IsNullOrEmpty(search.KorisnickoIme))
                query = Context.KorisnickiNalog.Where(k => string.Equals(k.KorisnickoIme, search.KorisnickoIme, StringComparison.CurrentCultureIgnoreCase));

            query = query.Include(i => i.KorisnickaUloga);

            IEnumerable<KorisnickiNalog> list = query.ToList();

            return list;
        }

        public KorisnickiNalog Autentificiraj(string korisnickoIme)
        {
            return Context.KorisnickiNalog.Where(k => k.KorisnickoIme == korisnickoIme).Include(k => k.KorisnickaUloga).FirstOrDefault();
        }
        
        /// <summary>
        /// Provjera da li korisničko ime već postoji
        /// </summary>
        /// <param name="korisnickoIme">Korisničko ime</param>
        /// <returns>True ukoliko je ime unikatno</returns>
        public bool ValidacijaKorisnickogImena(string korisnickoIme)
        {
            var nalog = Context.KorisnickiNalog.FirstOrDefault(k => string.Equals(k.KorisnickoIme, korisnickoIme, StringComparison.CurrentCultureIgnoreCase));
            return nalog == null;
        }

        public override KorisnickiNalog GetById(string id)
        {
            return Context.KorisnickiNalog.Where(w => w.Id == id).Include(i => i.KorisnickaUloga).FirstOrDefault();
        }
    }
}

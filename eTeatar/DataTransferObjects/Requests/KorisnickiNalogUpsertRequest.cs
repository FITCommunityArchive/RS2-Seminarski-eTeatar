﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects.Requests
{
    public class KorisnickiNalogUpsertRequest
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }

        public string Adresa { get; set; }
        public string GradId { get; set; }

        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }

        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
    }
}

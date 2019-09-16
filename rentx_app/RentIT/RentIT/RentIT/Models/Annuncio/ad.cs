﻿using RentIT.Models.User;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RentIT.Models.Annuncio
{
    
    public class Ad
    {

        public int Id { get; set; }

        public int AffittuarioId { get; set; }

        public string NomeOggetto { get; set; }

        public string Descrizione { get; set; }

        public string AnteprimaImg { get; set; }
       
        public decimal Prezzo { get; set; }

        public string Posizione { get; set; }

        public DateTime Data { get; set; }

        

        //Questi due servono solo per visualizzare gli annunci nelle liste. Non vengono salvati nel db
        public Image Immagine { get; set; }

        public Utente Affittuario { get; set; }
    }
}
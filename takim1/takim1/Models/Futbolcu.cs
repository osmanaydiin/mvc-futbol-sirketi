﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace takim1.Models
{
    public class Futbolcu
    {
        public int FutbolcuId { get; set; }
        public string FutbolcuAdi { get;set; }
        public string FutbolcuSoyadi { get;set; }
        public int? FutbolcuYas { get; set; }
        public float? FutbolcuDeger { get; set; }
        public float? FutbolcuMaas { get; set; }
        public string FutbolcuMevki { get; set; }
        public int? FutbolcuNumara { get; set; }
        public string? FutbolcuGecmis { get; set; }
        public string? FutbolcuResimUrl { get; set; }
        public int TakimId { get; set; }
        public virtual Takim Takim { get; set; }

    }
}

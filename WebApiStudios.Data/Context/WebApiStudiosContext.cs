using System;
using Microsoft.EntityFrameworkCore;
using WebApiStudios.Data.Models;

namespace WebApiStudios.Data.Context
{
    public class WebApiStudiosContext : DbContext
    {
       public DbSet<Studios> Studios { get; set; }
       public WebApiStudiosContext(DbContextOptions<WebApiStudiosContext> options) : base(options)
       {

       }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
       {

       }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Studios>().HasData(new Studios{name = "Чеширский кот", address = "г.Днепр, пр. Гагарина 43", phone = "+380982225252", price = "500₴", photo = "https://lh3.googleusercontent.com/oyB1ok9AJW4ECAalM7xhrc3KbAr_4dfdoENmVW1k_elkX84TFHZuLzpMuARkYAE7ztV2PMNHtj0Lul_utvr9n1pcFg=w1500-h1000-l95", link = "https://www.facebook.com/CheshireCat.foto/", addressLink = "https://www.google.com.ua/maps/place/%D0%BF%D1%80%D0%BE%D1%81%D0%BF.+%D0%93%D0%B0%D0%B3%D0%B0%D1%80%D0%B8%D0%BD%D0%B0,+43,+%D0%94%D0%BD%D0%B8%D0%BF%D1%80%D0%BE,+%D0%94%D0%BD%D0%B5%D0%BF%D1%80%D0%BE%D0%BF%D0%B5%D1%82%D1%80%D0%BE%D0%B2%D1%81%D0%BA%D0%B0%D1%8F+%D0%BE%D0%B1%D0%BB%D0%B0%D1%81%D1%82%D1%8C,+49000/@48.4384466,35.0468563,17z/data=!3m1!4b1!4m5!3m4!1s0x40dbe33342c191db:0x2128d8f592dee020!8m2!3d48.4384466!4d35.0490503?hl=ru"});
       }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
   public static class AddingDataInTables
    {
        public static int? bookingId = null;

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(

                   new Movie
                   {
                       Id = 1,
                       Title = "Alien",
                       Description = "After her last encounter," +
                   " Ellen Ripley crash-lands on Fiorina 161, a maximum security prison. When a series" +
                   " of strange and deadly events occur shortly after her arrival, Ripley realizes that " +
                   "she has brought along an unwelcome visitor",
                       FilePath = @"Alien.jpg"
                   },
                   new Movie
                   {
                       Id = 2,
                       Title = "Halloween",
                       Description = "Laurie Strode confronts her " +
                   "long-time foe Michael Myers, the masked figure who has haunted her since she narrowly " +
                   "escaped his killing spree on Halloween night four decades ago.",
                       FilePath = @"Halloween.jpg"
                   },
                   new Movie
                   {
                       Id = 3,
                       Title = "IT",
                       Description = "In the summer of 1989, a group of bullied" +
                   " kids band together to destroy a shape-shifting monster, which disguises itself as a " +
                   "clown and preys on the children of Derry, their small Maine town.",
                       FilePath = @"IT.jpg"
                   },
                   new Movie
                   {
                       Id = 4,
                       Title = "Poltergeist",
                       Description = "A family's home is haunted " +
                   "by a host of demonic ghosts.",
                       FilePath = @"Poltergeist.jpg"
                   },
                   new Movie
                   {
                       Id = 5,
                       Title = "Saw",
                       Description = "Two strangers awaken in a room with no" +
                   " recollection of how they got there, and soon discover they're pawns in a deadly game" +
                   " perpetrated by a notorious serial killer.",
                       FilePath = @"Saw.jpg"
                   },
                   new Movie
                   {
                       Id = 6,
                       Title = "Scream",
                       Description = "A year after the murder of her mother, " +
                   "a teenage girl is terrorized by a new killer, who targets the girl and her friends by using" +
                   " horror films as part of a deadly game.",
                       FilePath = @"Scream.jpg"
                   },
                   new Movie
                   {
                       Id = 7,
                       Title = "The Exorcist",
                       Description = "When a 12-year-old girl is possessed" +
                   " by a mysterious entity, her mother seeks the help of two priests to save her.",
                       FilePath = @"TheExorcist.jpg"
                   },
                   new Movie
                   {
                       Id = 8,
                       Title = "The Grudge",
                       Description = "An American nurse living and working" +
                   " in Tokyo is exposed to a mysterious supernatural curse, one that locks a person in a " +
                   "powerful rage before claiming their life and spreading to another victim.",
                       FilePath = @"TheGrudge.jpg"
                   },
                   new Movie
                   {
                       Id = 9,
                       Title = "The Ring",
                       Description = "A journalist must investigate a mysterious " +
                   "videotape which seems to cause the death of anyone one week to the day after they view it.",
                       FilePath = @"TheRing.jpg"
                   },
                   new Movie
                   {
                       Id = 10,
                       Title = "The Witch",
                       Description = "A family in 1630s New England is torn " +
                   "apart by the forces of witchcraft, black magic, and possession.",
                       FilePath = @"TheWitch.jpg"
                   }) ;

            for (int i = 1; i < 11; i++)
            {
                modelBuilder.Entity<Room>().HasData(
               new Room
               {
                   Id = i,
                   RoomNumber = i,                
                  
               });

            }

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Desire", LastName = "Tillerås", PhoneNumber = "0700000001"},
                new Customer { Id = 2, FirstName = "Tintin", LastName = "Petersson", PhoneNumber = "0700000002" },
                new Customer { Id = 3, FirstName = "Amanda", LastName = "Eriksson", PhoneNumber = "0700000003" },
                new Customer { Id = 4, FirstName = "Jonathan", LastName = "Kullman", PhoneNumber = "0700000004" },
                new Customer { Id = 5, FirstName = "Jesper", LastName = "Hultén", PhoneNumber = "0700000005" },
                new Customer { Id = 6, FirstName = "Eva-Marie", LastName = "Tillerås", PhoneNumber = "0700000006" },
                new Customer { Id = 7, FirstName = "Linda", LastName = "Johansson", PhoneNumber = "0700000007" },
                new Customer { Id = 8, FirstName = "Alma", LastName = "Ragnarsson", PhoneNumber = "0700000008" },
                new Customer { Id = 9, FirstName = "Emmiline", LastName = "Larsson", PhoneNumber = "0700000009" },
                new Customer { Id = 10, FirstName = "Madeleine", LastName = "Ivarsson", PhoneNumber = "0700000010" });

            modelBuilder.Entity<ShowTime>().HasData(
                
                new ShowTime { Id = 1, ShowNumber = 1, Time = "2021-06-18 20:00"},
                new ShowTime { Id = 2, ShowNumber = 2, Time = "2021-06-18 22:00"},
                new ShowTime { Id = 3, ShowNumber = 3, Time = "2021-06-18 24:00"},
                new ShowTime { Id = 4, ShowNumber = 4, Time = "2021-06-17 02:00"});

           
        }

        public static void Seed2(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasData(
                new Booking { Id = 1, CustomerId = 1, MovieId = 1 },
                new Booking { Id = 2, CustomerId = 2, MovieId = 2 },
                new Booking { Id = 3, CustomerId = 3, MovieId = 3 },
                new Booking { Id = 4, CustomerId = 4, MovieId = 4 },
                new Booking { Id = 5, CustomerId = 5, MovieId = 5 },
                new Booking { Id = 6, CustomerId = 6, MovieId = 6 },
                new Booking { Id = 7, CustomerId = 7, MovieId = 7 },
                new Booking { Id = 8, CustomerId = 8, MovieId = 8 },
                new Booking { Id = 9, CustomerId = 9, MovieId = 9 },
                new Booking { Id = 10, CustomerId = 10, MovieId = 10 }


                ) ;

        }


  
        
        public static void Seed3(this ModelBuilder modelBuilder)
        {
            int seatNumber = 0;
            

            for (int i = 1; i < 801; i++)
            {
                seatNumber++;
                int number = 0;
                int showNumber = 0;
                if(seatNumber == 21) { seatNumber = 1; }

                if (i >= 1 && i <= 80)
                {
                    number = 1;
                    if (i >= 1 && i <= 20) { showNumber = 1; }
                    if (i >= 21 && i <= 40) { showNumber = 2; }
                    if (i >= 41 && i <= 60) { showNumber = 3; }
                    if (i >= 61 && i <= 80) { showNumber = 4; }                   

                }                
                if (i >= 81 && i <= 160)
                {
                    number = 2;
                    if (i >= 81 && i <= 100) { showNumber = 1; }
                    if (i >= 101 && i <= 120) { showNumber = 2; }
                    if (i >= 121 && i <= 140) { showNumber = 3; }
                    if (i >= 141 && i <= 180) { showNumber = 4; }

                }

                if (i >= 161 && i <= 240)
                {
                    number = 3;
                    if (i >= 161 && i <= 180) { showNumber = 1; }
                    if (i >= 181 && i <= 200) { showNumber = 2; }
                    if (i >= 201 && i <= 220) { showNumber = 3; }
                    if (i >= 221 && i <= 240) { showNumber = 4; }

                }
                if (i >= 241 && i <= 320)
                {
                    number = 4;
                    if (i >= 241 && i <= 260) { showNumber = 1; }
                    if (i >= 261 && i <= 280) { showNumber = 2; }
                    if (i >= 281 && i <= 300) { showNumber = 3; }
                    if (i >= 301 && i <= 320) { showNumber = 4; }
                }
                if (i >= 321 && i <= 400)
                {
                    number = 5;
                    if (i >= 321 && i <= 340) { showNumber = 1; }
                    if (i >= 341 && i <= 360) { showNumber = 2; }
                    if (i >= 361 && i <= 380) { showNumber = 3; }
                    if (i >= 381 && i <= 400) { showNumber = 4; }
                }
                if (i >= 401 && i <= 480)
                {
                    number = 6;
                    if (i >= 401 && i <= 420) { showNumber = 1; }
                    if (i >= 421 && i <= 440) { showNumber = 2; }
                    if (i >= 441 && i <= 460) { showNumber = 3; }
                    if (i >= 461 && i <= 480) { showNumber = 4; }
                }
                if (i >= 481 && i <= 560)
                {
                    number = 7;
                    if (i >= 481 && i <= 500) { showNumber = 1; }
                    if (i >= 501 && i <= 520) { showNumber = 2; }
                    if (i >= 521 && i <= 540) { showNumber = 3; }
                    if (i >= 541 && i <= 560) { showNumber = 4; }
                }
                if (i >= 561 && i <= 640)
                {
                    number = 8;
                    if (i >= 561 && i <= 580) { showNumber = 1; }
                    if (i >= 581 && i <= 600) { showNumber = 2; }
                    if (i >= 601 && i <= 620) { showNumber = 3; }
                    if (i >= 621 && i <= 640) { showNumber = 4; }
                }
                if (i >= 641 && i <= 720)
                {
                    number = 9;
                    if (i >= 641 && i <= 660) { showNumber = 1; }
                    if (i >= 661 && i <= 680) { showNumber = 2; }
                    if (i >= 681 && i <= 700) { showNumber = 3; }
                    if (i >= 701 && i <= 720) { showNumber = 4; }
                }
                if (i >= 721 && i <= 800)
                {
                    number = 10;
                    if (i >= 721 && i <= 740) { showNumber = 1; }
                    if (i >= 741 && i <= 760) { showNumber = 2; }
                    if (i >= 761 && i <= 780) { showNumber = 3; }
                    if (i >= 781 && i <= 800) { showNumber = 4; }
                }

                if(i == 1) { bookingId = 1; }
                if(i == 3) { bookingId = null; }
                if(i == 81) { bookingId = 2; }
                if(i == 82) { bookingId = null; }
                if(i == 161) { bookingId = 3; }
                if(i == 163) { bookingId = null; }
                if(i == 241) { bookingId = 4; }
                if(i == 242) { bookingId = null; }
                if(i == 321) { bookingId = 5; }
                if(i == 322) { bookingId = null; }
                if(i == 401) { bookingId = 6; }
                if(i == 402) { bookingId = null; }
                if(i == 481) { bookingId = 7; }
                if(i == 482) { bookingId = null; }
                if(i == 561) { bookingId = 8; }
                if(i == 562) { bookingId = null; }
                if(i == 641) { bookingId = 9; }
                if(i == 642) { bookingId = null; }
                if(i == 721) { bookingId = 10; }
                if(i == 723) { bookingId = null; }


                modelBuilder.Entity<Ticket>().HasData(
                    new Ticket
                    {
                        Id = i,
                        RoomId = number,
                        ShowTimeId = showNumber,
                        BookingId = bookingId,
                        SeatNumber = seatNumber


                    }); ;
            }
        }
    }
}

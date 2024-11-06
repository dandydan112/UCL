using System.Collections.Generic;

namespace SurfsUpBlazor.Models
{
    public class SurfBoardRepository
    {
        public List<Surfboard> GetSurfboards()
        {
            return new List<Surfboard>
            {
              new Surfboard { SurfboardId = 1, Name = "The Minilog", Length = 6d, Width = 21d, Thickness = 2.75d, Volume = 38.8d, PriceOfPurchase = 565d, Equipment = null, HourlyPrice = -1},
            new Surfboard { SurfboardId = 2, Name = "The Wide Glider", Length = 7.1d, Width = 21.75d, Thickness = 2.75d, Volume = 44.16d, PriceOfPurchase = 685d, Equipment = null, HourlyPrice = -1},
            new Surfboard { SurfboardId = 3, Name = "The Golden Ratio", Length = 6.3d, Width = 21.85d, Thickness = 2.9d, Volume = 43.22d, PriceOfPurchase = 695d, Equipment = null, HourlyPrice = -1},
            new Surfboard { SurfboardId = 4, Name = "Mahi Mahi", Length = 5.4d, Width = 20.75d, Thickness = 2.3d, Volume = 29.39d, PriceOfPurchase = 645d, Equipment = null, HourlyPrice = -1},
            new Surfboard { SurfboardId = 5, Name = "The Emerald Glider", Length = 9.2d, Width = 22.8d, Thickness = 2.8d, Volume = 65.4d, PriceOfPurchase = 895d, Equipment = null, HourlyPrice = -1},
            new Surfboard { SurfboardId = 6, Name = "The Bomb", Length = 5.5d, Width = 21d, Thickness = 2.5d, Volume = 33.7d, PriceOfPurchase = 645d, Equipment = null, HourlyPrice = -1},
            new Surfboard { SurfboardId = 7, Name = "Walden Magic", Length = 9.6d, Width = 19.4d, Thickness = 3d, Volume = 80d, PriceOfPurchase = 1025d, Equipment = null, HourlyPrice = -1},
            new Surfboard { SurfboardId = 8, Name = "Naish One", Length = 12.6d, Width = 30d, Thickness = 6d, Volume = 301d, PriceOfPurchase = 854d, Equipment = "Paddle", HourlyPrice = -1},
            new Surfboard { SurfboardId = 9, Name = "Six Tourer", Length = 11.6d, Width = 32d, Thickness = 6d, Volume = 270d, PriceOfPurchase = 611d, Equipment = "Fin, Paddle, Pump, Leash", HourlyPrice = -1},
            new Surfboard { SurfboardId = 10, Name = "Naish Maliko", Length = 14d, Width = 25d, Thickness = 6d, Volume = 330d, PriceOfPurchase = 1304d, Equipment = "Fin, Paddle, Pump, Leash", HourlyPrice = -1},
            };

        }
    }
}

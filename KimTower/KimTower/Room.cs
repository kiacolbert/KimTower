﻿using System;
namespace KimTower
{
    public interface IRoom
    {

        bool Occupied { get; set; }

        int MaintenanceCost { get; set; }

        int Capacity { get; set; }

        int Population { get; set; }

        int IsLit { get; set; }

        int ConstructionCost { get; set; }

        Position Position { get; set; }

        int Floor { get; set; }

        int Revenue { get; set; }


    }

    public class Office : IRoom
    {
        public bool Occupied { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaintenanceCost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Population { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IsLit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ConstructionCost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Position Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Floor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Revenue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

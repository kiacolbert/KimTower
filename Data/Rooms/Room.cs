﻿namespace KimTower.Data.Rooms
{
    using System.Collections.Generic;

    public abstract class Room : IRoom
    {
        public List<Person> People { get; set; }

        public int Segments { get; private set; }

        public Range Range { get; set; }

        public int Cost { get; }

        public bool Occupied { get; set; }

        public int FloorNumber { get; set; }

        public int Population { get; }

        protected Room(int segments, int cost, int x, int floorNumber, int population)
        {
            this.People = new List<Person>();
            this.Segments = segments;
            this.Cost = cost;
            this.Range = new Range(x, x + segments);
            this.FloorNumber = floorNumber;
            this.Population = population;

        }

        public void SetOccupancy(Tower tower, int floorNumber)
        {
            if (tower.HasFirstFloorAccess(floorNumber))
            {
                this.Occupied = true;
            }

        }
    }
}   
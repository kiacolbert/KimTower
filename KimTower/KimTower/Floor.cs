﻿using System;
using System.Collections.Generic;
namespace KimTower
{
    public interface IFloor
    {

        Range Range { get; set; }

        int ParentFloor { get; }

        int FloorNumber { get; }

        //int MaintenanceCost { get; }

        int Segments { get; set; }


        List<IBetterTransportation> Transportations { get; set; }

        List<IRoom> Rooms { get; set; }


        void ExtendFloor(int coordinate);
    }
    //people can be in lobbies
    //public class Lobby : IFloor
    //{
    //    private int parentFloor = 0;

    //    public Range Range { get; set; }

    //    public int ParentFloor => parentFloor;

    //    public int FloorNumber { get; set;}

    //    public int Segments { get; set; }
    //    public List<ITransportation> Transportation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void ExtendFloor(int coordinate)
    //    {
            
    //        if (coordinate < 0)
    //        {
    //            this.Range = new Range(this.Range.XCoordinate + coordinate, this.Range.XCoordinate);

    //        }
    //        else
    //        {
    //            this.Range = new Range(this.Range.XCoordinate, this.Range.XCoordinate + coordinate);
    //        }

    //        this.Segments += Math.Abs(coordinate);
    //    }
    //}
    //floors can not be deleted
    public class Floor : IFloor
    {
        public Range Range { get; set; }

        //public int MaintenanceCost { get { return 0; } }

        public int Segments { get; set; }

        public bool IsBelowGround { get; set; }

        public int ParentFloor { get; set; }
        
        public int FloorNumber
        {
            get
            {
                if (!IsBelowGround)
                {
                    return this.ParentFloor + 1;
                }
                else
                {
                    if (this.ParentFloor == 1)
                    {
                        return -1;
                    }
                    return this.ParentFloor - 1;
                }
            }
        }

        public ElevatorShaft ElevatorShaft{ get; set; }

        public List<IBetterTransportation> Transportations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IRoom> Rooms { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Floor(Range range, int segments, int parentfloor, bool isBelowGround)
        {
            this.ParentFloor = parentfloor;
            this.Range = new Range(range.XCoordinate, range.XSecondCoordinate);
            this.Segments = segments;
            this.IsBelowGround = isBelowGround;
        }
        public Floor()
        {

        }
        public void AddElevatorShaft(int x)
        {
            this.ElevatorShaft = new ElevatorShaft(this, x);
        }
        public void ExtendFloor(int coordinate)
        {
            if(coordinate < 0)
            {
                this.Range = new Range(this.Range.XCoordinate + coordinate, this.Range.XCoordinate);

            }
            else
            {
                this.Range = new Range(this.Range.XCoordinate, this.Range.XCoordinate + coordinate);
            }

            this.Segments += Math.Abs(coordinate);
        }
    }

}

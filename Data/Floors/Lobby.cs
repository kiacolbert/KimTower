﻿
namespace KimTower.Data.Floors
{

    public class Lobby : BasicFloor, IFloor
    {
        static int segments = StructureInfo.lobbyInfo.Segments;
        static int cost = StructureInfo.lobbyInfo.ConstructionCost;

        //fix this
        public int Population { get; set; }

        public Lobby(int x) : base(new Range(x, x + segments))
        {
           
        }

    }
}

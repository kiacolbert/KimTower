﻿
namespace KimTower.Data.Transportation
{

    public class StairCase : ITransportation
    {
        static int segments = StructureInfo.stairCaseInfo.Segments;
        static int cost = StructureInfo.stairCaseInfo.ConstructionCost;

        public int BottomFloor { get; set; }

        public int TopFloor { get; set; }

        public int Segememts => segments;

        public int Cost => cost;

        public StairCase(int bottomFloor)
        {
            this.BottomFloor = bottomFloor;
            this.TopFloor = bottomFloor + 1;
        }


    }
}

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Graphs")]
    [ActionTitle("Flood Fill Graphs")]
    [ActionDescription("Flood fills graphs forcing updates to propogate")]
    public class FloodFillGraphsAction : UFAction
    {
        [In]
        public GraphNode StartingNode;

        [In]
        public int Area;
    
        public override void Execute()
        {
            if (StartingNode == null)
            { AstarPath.active.FloodFill(); }
            else if (Area <= 0)
            { AstarPath.active.FloodFill(StartingNode); }
            else
            { AstarPath.active.FloodFill(StartingNode, (uint)Area); }
        }
    }
}
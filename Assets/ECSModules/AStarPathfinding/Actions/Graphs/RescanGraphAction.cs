

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Graphs")]
    [ActionTitle("Rescan Graph")]
    [ActionDescription("Rescans the graph to see if any changes have occurred")]
    public class RescanGraphAction : UFAction
    {
        [In]
        public NavGraph Graph;

        public override void Execute()
        {
            Graph.ScanInternal();
        }
    }
}
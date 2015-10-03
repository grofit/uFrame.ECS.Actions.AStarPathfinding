


using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Graphs")]
    [ActionTitle("Rescan Graphs")]
    [ActionDescription("Rescans all graphs in the scene")]
    public class RescanGraphsAction : UFAction
    {
        public override void Execute()
        {
            AstarPath.active.Scan();
        }
    }
}
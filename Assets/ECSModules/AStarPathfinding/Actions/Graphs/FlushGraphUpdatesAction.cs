


using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Graphs")]
    [ActionTitle("Flush Graph Updates")]
    [ActionDescription("Flushes all graph updates")]
    public class FlushGraphUpdatesAction : UFAction
    {
        public override void Execute()
        {
            AstarPath.active.FlushGraphUpdates();
        }
    }
}
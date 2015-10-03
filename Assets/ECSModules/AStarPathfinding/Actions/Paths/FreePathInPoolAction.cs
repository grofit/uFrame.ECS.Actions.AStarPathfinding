using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Free Path In Pool")]
    [ActionDescription("Frees the path from the pathing pool")]
    public class FreePathInPoolAction : UFAction
    {
        [In]
        public Path Path;

        public override void Execute()
        {
            Path.Release(EntityView);
        }
    }
}
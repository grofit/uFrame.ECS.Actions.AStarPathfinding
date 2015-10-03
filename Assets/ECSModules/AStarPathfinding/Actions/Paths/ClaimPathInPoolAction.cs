using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [ActionLibrary]
    [uFrameCategory("A* Pathfinding")]
    [ActionDescription("Claims the path in the pathing pool")]
    [ActionTitle("Claim Path In Pool")]
    public class ClaimPathInPoolAction : UFAction
    {
        [In]
        public Path Path;

        public override void Execute()
        {
            Path.Claim(EntityView);
        }
    }
}
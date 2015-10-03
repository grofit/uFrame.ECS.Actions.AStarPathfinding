using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Reverse Path")]
    [ActionDescription("Reverses a given path")]
    public class ReversePathAction : UFAction
    {
        [In]
        public Path Path;

        [Out]
        public Path ReversedPath;

        public override void Execute()
        {
            ReversedPath = Path.ReversePath();
        }
    }
}
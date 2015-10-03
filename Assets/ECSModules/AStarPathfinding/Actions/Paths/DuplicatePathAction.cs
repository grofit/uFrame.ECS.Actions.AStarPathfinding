

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Duplicate Path")]
    [ActionDescription("Duplicates a given path")]
    public class DuplicatePathAction : UFAction
    {
        [In]
        public Path Path;

        [Out]
        public Path DuplicatePath;

        public override void Execute()
        {
            DuplicatePath = Path.DuplicatePath();
        }
    }
}
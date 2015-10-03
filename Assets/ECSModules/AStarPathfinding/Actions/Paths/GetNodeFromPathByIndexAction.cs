

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Get Node From Path By Index")]
    [ActionDescription("Gets a node from a path by index")]
    public class GetNodeFromPathByIndexAction : UFAction
    {
        [In]
        public Path Path;

        [In]
        public int Index;

        [Out]
        public GraphNode Node;

        public override void Execute()
        {
            if(Path.path.Count >= Index)
            { return; }

            Node = Path.path[Index];
        }
    }
}
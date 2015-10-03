

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Graphs")]
    [ActionTitle("Get Graph From Node")]
    [ActionDescription("Gets a graph from a node")]
    public class GetGraphFromNodeAction : UFAction
    {
        [In]
        public GraphNode Node;

        [Out]
        public NavGraph LocatedGraph;

        public override void Execute()
        {
            LocatedGraph = AstarPath.active.graphs[Node.GraphIndex];
        }
    }
}
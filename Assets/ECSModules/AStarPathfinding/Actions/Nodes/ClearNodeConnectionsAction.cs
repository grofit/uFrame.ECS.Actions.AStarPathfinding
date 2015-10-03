

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Clear Nodes Connections")]
    [ActionDescription("Clears all nodes connections")]
    public class ClearNodeConnectionsAction : UFAction
    {
        [In]
        public GraphNode Node;

        [In]
        public bool ClearReverse;

        public override void Execute()
        {
            Node.ClearConnections(ClearReverse);
        }
    }
}


using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Add Connection To Node")]
    [ActionDescription("Adds a connection to the node with an associated cost (must be positive)")]
    public class AddConnectionToNodeAction : UFAction
    {
        [In]
        public GraphNode Node;

        [In]
        public GraphNode ConnectingNode;

        [In]
        public int ConnectionCost;

        public override void Execute()
        {
            Node.AddConnection(ConnectingNode, (uint)ConnectionCost);
        }
    }
}
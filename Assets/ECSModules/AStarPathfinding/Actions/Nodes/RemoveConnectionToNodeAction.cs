

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Add Connection To Node")]
    [ActionDescription("Removes a connected node")]
    public class RemoveConnectionToNodeAction : UFAction
    {
        [In]
        public GraphNode Node;

        [In]
        public GraphNode ConnectedNode;

        public override void Execute()
        {
            Node.RemoveConnection(ConnectedNode);
        }
    }
}
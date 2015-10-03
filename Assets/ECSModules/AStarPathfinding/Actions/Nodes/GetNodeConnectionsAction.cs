using System.Collections.Generic;


using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Get Node Connections")]
    [ActionDescription("Gets all connections for a node")]
    public class GetNodeConnectionsAction : UFAction
    {
        [In]
        public GraphNode Node;
    
        [Out]
        public List<GraphNode> ConnectionList = new List<GraphNode>();

        public override void Execute()
        {
            Node.GetConnections(connectedNode => ConnectionList.Add(connectedNode));
        }
    }
}
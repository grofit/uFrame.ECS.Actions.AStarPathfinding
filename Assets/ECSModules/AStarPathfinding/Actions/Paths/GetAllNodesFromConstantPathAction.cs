using System.Collections.Generic;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding - Pro")]
    [ActionTitle("Get All Nodes From Constant Path")]
    [ActionDescription("Get all nodes from a constant path")]
    public class GetAllNodesFromConstantPathAction : UFAction
    {
        [In]
        public ConstantPath Path;

        [Out]
        public List<GraphNode> NodeList;

        public override void Execute()
        {
            NodeList = Path.allNodes;
        }
    }
}
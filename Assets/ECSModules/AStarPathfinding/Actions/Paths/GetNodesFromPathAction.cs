using System.Collections.Generic;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Get Nodes From Path")]
    [ActionDescription("Get nodes from an existing path")]
    public class GetNodesFromPathAction : UFAction
    {
        [In]
        public Path Path;

        [Out]
        public List<GraphNode> NodeList;

        public override void Execute()
        {
            NodeList = Path.path;
        }
    }
}
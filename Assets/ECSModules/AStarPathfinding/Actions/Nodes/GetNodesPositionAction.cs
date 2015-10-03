

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Get Nodes Position")]
    [ActionDescription("Gets the underlying position of a Node")]
    public class GetNodesPositionAction : UFAction
    {
        [In]
        public GraphNode Node;

        [Out]
        public Vector3 Position;

        public override void Execute()
        {
            Position = (Vector3)Node.position;
        }
    }
}
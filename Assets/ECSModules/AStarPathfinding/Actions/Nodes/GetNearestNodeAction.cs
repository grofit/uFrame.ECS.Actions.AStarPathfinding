

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Get Nearest Node")]
    [ActionDescription("Finds the nearest node to a position")]
    public class GetNearestNodeAction : UFAction
    {
        [In]
        public Vector3 Position;

        [Out]
        public GraphNode NearestNode;

        public override void Execute()
        {
            var closestResult = AstarPath.active.GetNearest(Position);
            if (closestResult.node == null) { return; }

            NearestNode = closestResult.node;
        }
    }
}
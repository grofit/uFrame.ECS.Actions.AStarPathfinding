using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Get Closest Node In Path")]
    [ActionDescription("Gets the closest node in an existing path")]
    public class GetClosestNodeInPathAction : UFAction
    {
        [In]
        public Path Path;

        [In]
        public Vector3 PositionToCheck;

        [Out]
        public GraphNode OutputNode;

        [Out]
        public float DistanceToClosest;

        public override void Execute()
        {
            if(Path.vectorPath.Count == 0) { return; }

            var closestNode = Path.FindClosestNodeTo(PositionToCheck);
            OutputNode = closestNode;
            if (DistanceToClosest > 0 || DistanceToClosest < 0)
            {
                var nodePosition = (Vector3) closestNode.position;
                DistanceToClosest = Vector3.Distance(nodePosition, PositionToCheck);
            }
        }
    }
}
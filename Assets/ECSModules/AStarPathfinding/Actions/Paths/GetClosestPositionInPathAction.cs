using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Get Closest Position In Path")]
    [ActionDescription("Gets the closest position in an existing path")]
    public class GetClosestPositionInPathAction : UFAction
    {
        [In]
        public Path Path;

        [In]
        public Vector3 PositionToCheck;

        [Out]
        public Vector3 OutputVector;

        [Out]
        public float DistanceToClosest;

        public override void Execute()
        {
            if (Path.vectorPath.Count == 0) { return; }

            var closestNode = Path.FindClosestPositionTo(PositionToCheck);
            OutputVector = closestNode;

            if (DistanceToClosest > 0 || DistanceToClosest < 0)
            { DistanceToClosest = Vector3.Distance(closestNode, PositionToCheck); }
        }
    }
}


using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Get Distance Of Path")]
    [ActionDescription("Gets the distance of a given path")]
    public class GetDistanceOfPathAction : UFAction
    {
        [In]
        public Path Path;

        [Out]
        public float TotalDistance;

        public override void Execute()
        {
            TotalDistance = Path.vectorPath.Count > 1 ? GetTotalDistanceOfPath(Path) : 0;
        }

        private float GetTotalDistanceOfPath(Path path)
        {
            var totalDistance = 0.0f;
            for (var i = 1; i < path.vectorPath.Count; i++)
            {
                var previousPosition = path.vectorPath[i - 1];
                var nextPosition = path.vectorPath[i];
                totalDistance = Vector3.Distance(previousPosition, nextPosition);
            }
            return totalDistance;
        }
    }
}
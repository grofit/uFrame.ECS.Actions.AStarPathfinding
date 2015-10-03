using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Is Path Possible")]
    [ActionDescription("Checks to see if a path is possible between 2 positions")]
    public class IsPathPossibleCondition : UFAction
    {
        [In]
        public Vector3 StartPoint;

        [In]
        public Vector3 EndPoint;

        [In]
        public float MaximumDistanceFromPoint;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            var startNode = AstarPath.active.GetNearest(StartPoint).node;
            if (MaximumDistanceFromPoint > 0)
            {
                var startDistance = Vector3.Distance((Vector3) startNode.position, StartPoint);
                if (startDistance > MaximumDistanceFromPoint)
                {
                    False();
                    return;
                }
            }

            var destinationNode = AstarPath.active.GetNearest(EndPoint).node;
            if (MaximumDistanceFromPoint > 0)
            {
                var endDistance = Vector3.Distance((Vector3)destinationNode.position, EndPoint);
                if (endDistance > MaximumDistanceFromPoint)
                {
                    False();
                    return;
                }
            }

            if(PathUtilities.IsPathPossible(startNode, destinationNode))
            { True(); }
            else
            { False(); }
        }
    }
}
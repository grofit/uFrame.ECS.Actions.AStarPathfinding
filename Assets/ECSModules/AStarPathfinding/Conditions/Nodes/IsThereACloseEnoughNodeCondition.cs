using System;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Is There A Close Enough Node")]
    [ActionDescription("Checks to see if a node is close enough to a position")]
    public class IsThereACloseEnoughNodeCondition : UFAction
    {
        [In]
        public Vector3 Position;

        [In]
        public float MaximumDistance;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            var closestResult = AstarPath.active.GetNearest(Position);
            if (closestResult.node == null)
            {
                False();
                return;
            }

            var nearestNode = closestResult.node;
            var distance = Vector3.Distance((Vector3)nearestNode.position, Position);
            if(distance <= MaximumDistance)
            { True(); }
            else
            { False(); }
        }
    }
}
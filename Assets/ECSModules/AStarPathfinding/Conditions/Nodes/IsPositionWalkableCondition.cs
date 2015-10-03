using System;
using System.Linq;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Is Position Walkable")]
    [ActionDescription("Checks to see if a position is walkable")]
    public class IsPositionWalkableCondition : UFAction
    {
        [In]
        public Vector3 PositionToCheck;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(AstarPath.active.graphs.Any(isGraphWalkable))
            { True(); }
            else
            { False(); }
        }

        private bool isGraphWalkable(NavGraph graph)
        {
            var nearestNode = graph.GetNearest(PositionToCheck);
            return nearestNode.node != null && nearestNode.node.Walkable;
        }
    }
}
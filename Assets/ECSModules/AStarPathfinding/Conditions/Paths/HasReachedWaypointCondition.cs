using System;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Has Reached Waypoint")]
    [ActionDescription("Checks to see if the agent is close enough to waypoint")]
    public class HasReachedWaypointCondition : UFAction
    {
        [In] public Vector3 SourcePosition;

        [In]
        public Vector3 Waypoint;

        [In]
        public float AcceptableDistance = 0.1f;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            var distance = Vector3.Distance(Waypoint, SourcePosition);
            if(distance <= AcceptableDistance)
            { True(); }
            else
            { False(); }
        }
    }
}
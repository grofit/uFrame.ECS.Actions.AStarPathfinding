using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Has Reached Node")]
    [ActionDescription("Checks to see if the agent is close enough to node")]
    public class HasReachedNodeCondition : UFAction
    {
        [In]
        public Vector3 SourcePosition;

        [In]
        public GraphNode Node;

        [In]
        public float AcceptableDistance = 0.1f;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            var nodeAsWaypoint = (Vector3) Node.position;
            var distance = Vector3.Distance(nodeAsWaypoint, SourcePosition);
            if(distance <= AcceptableDistance)
            { True(); }
            else
            { False(); }
        }
    }
}
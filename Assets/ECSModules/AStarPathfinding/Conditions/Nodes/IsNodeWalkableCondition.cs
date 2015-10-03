using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Is Node Walkable")]
    [ActionDescription("Checks to see if a node is walkable")]
    public class IsNodeWalkableCondition : UFAction
    {
        [In]
        public GraphNode NodeToCheck;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(NodeToCheck.Walkable)
            { True(); }
            else
            { False(); }
        }
    }
}
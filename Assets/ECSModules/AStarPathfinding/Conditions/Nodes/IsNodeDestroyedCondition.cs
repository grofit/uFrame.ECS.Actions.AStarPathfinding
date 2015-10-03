using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Is Node Destroyed")]
    [ActionDescription("Checks to see if a node is destroyed")]
    public class IsNodeDestroyedCondition : UFAction
    {
        [In]
        public GraphNode NodeToCheck;

        [Out]
        public Action True;

        [Out]
        public Action False;
        
        public override void Execute()
        {
            if(NodeToCheck.Destroyed)
            { True(); }
            else
            { False(); }
        }
    }
}
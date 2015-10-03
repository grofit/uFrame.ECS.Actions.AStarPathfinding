using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Node Contains Connection")]
    [ActionDescription("Checks to see if a node contains a given connection")]
    public class NodeContainsConnectionCondition : UFAction
    {
        [In]
        public GraphNode NodeToCheck;

        [In]
        public GraphNode ConnectingNode;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(NodeToCheck.ContainsConnection(ConnectingNode))
            { True(); }
            else
            { False(); }
        }
    }
}


using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Get Node Penalty")]
    [ActionDescription("Gets the penalty for a node")]
    public class GetNodePenaltyAction : UFAction
    {
        [In]
        public GraphNode NodeToCheck;

        [Out]
        public int Penalty;

        public override void Execute()
        {
            Penalty = (int)NodeToCheck.Penalty;
        }
    }
}


using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Recalculate Node Connection Costs")]
    [ActionDescription("Recalculates a nodes connection costs")]
    public class RecalculateNodeConnectionCostsAction : UFAction
    {
        [In]
        public GraphNode Node;

        public override void Execute()
        {
            Node.RecalculateConnectionCosts();
        }
    }
}
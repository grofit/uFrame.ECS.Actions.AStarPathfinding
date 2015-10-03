

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Get Node Walkability")]
    [ActionDescription("Gets a boolean indicating if the path is walkable")]
    public class GetNodeWalkabilityAction : UFAction
    {
        [In]
        public GraphNode NodeToCheck;

        [Out]
        public bool Walkability;

        public override void Execute()
        {
            Walkability = NodeToCheck.Walkable;
        }
    }
}
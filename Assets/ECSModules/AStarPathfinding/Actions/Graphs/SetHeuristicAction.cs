


using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Set Heuristic")]
    [ActionDescription("Sets the heuristic to use when calculating paths")]
    public class SetHeuristicAction : UFAction
    {
        [In]
        public Heuristic Heuristic = Heuristic.Euclidean;

        public override void Execute()
        {
            AstarPath.active.heuristic = Heuristic;
        }
    }
}
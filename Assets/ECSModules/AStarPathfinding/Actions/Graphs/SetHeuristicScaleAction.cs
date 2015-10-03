


using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Set Heuristic Scale")]
    [ActionDescription("Sets the heuristic scale to use when calculating paths")]
    public class SetHeuristicScaleAction : UFAction
    {
        [In]
        public float HeuristicScale;

        public override void Execute()
        {
            AstarPath.active.heuristicScale = HeuristicScale;
        }
    }
}


using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Graphs")]
    [ActionTitle("Update Graphs")]
    [ActionDescription("Updates graphs nodes within a given boundry")]
    public class UpdateGraphsAction : UFAction
    {
        [In]
        public Bounds UpdateBoundry;

        public override void Execute()
        {
            AstarPath.active.UpdateGraphs(UpdateBoundry);
        }
    }
}
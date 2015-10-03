using Pathfinding;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameEvent("Path Created")]
    [uFrameCategory("A* Pathfinding")]
    public class PathCreatedEvent
    {
        public Path CreatedPath;
    }
}
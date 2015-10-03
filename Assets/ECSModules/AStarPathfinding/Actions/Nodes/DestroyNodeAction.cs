

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Nodes")]
    [ActionTitle("Destroy Node")]
    [ActionDescription("Destroys a node")]
    public class DestroyNodeAction : UFAction
    {
        [In]
        public GraphNode Node;
    
        public override void Execute()
        {
            Node.Destroy();
        }
    }
}
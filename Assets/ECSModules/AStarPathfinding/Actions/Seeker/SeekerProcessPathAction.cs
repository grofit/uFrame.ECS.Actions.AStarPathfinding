

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Seeker Process Path")]
    [ActionDescription("Tells the seeker to process the given path making use of modifiers attached")]
    public class SeekerProcessPathAction : UFAction
    {
        [In]
        public Path Path;
        
        public override void Execute()
        {
            var seeker = EntityView.GetComponent<Seeker>();
            seeker.PostProcess(Path);
        }
    }
}
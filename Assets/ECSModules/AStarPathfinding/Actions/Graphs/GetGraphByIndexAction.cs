

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace NodeCanvasAddons
{
    [uFrameCategory("A* Pathfinding", "Graphs")]
    [ActionTitle("Get Graph By Index")]
    [ActionDescription("Gets a graph in the scene by index")]
    public class GetGraphByIndexAction : UFAction
    {
        [In]
        public int GraphIndex;

        [Out]
        public NavGraph LocatedGraph;

        public override void Execute()
        {
            if (AstarPath.active.graphs.Length <= GraphIndex)
            { return; }

            LocatedGraph = AstarPath.active.graphs[GraphIndex];
        }
    }
}
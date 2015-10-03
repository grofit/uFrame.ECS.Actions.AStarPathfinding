//#define IS_ASTAR_FREE


#if IS_ASTAR_FREE
namespace Pathfinding
{
	public class ConstantPath : Path
	{	
		public static ConstantPath Construct (Vector3 start, int maxGScore, OnPathDelegate callback)
        { return null; }

	    public List<GraphNode> allNodes;

        protected override void Recycle()
        {
            throw new System.NotImplementedException();
        }

        public override void Prepare()
        {
            throw new System.NotImplementedException();
        }

        public override void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public override void CalculateStep(long targetTick)
        {
            throw new System.NotImplementedException();
        }
	}
}
#endif
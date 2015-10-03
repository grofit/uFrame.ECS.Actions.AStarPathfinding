//#define IS_ASTAR_FREE


#if IS_ASTAR_FREE
namespace Pathfinding
{
	public class FleePath  : Path
	{	
		public static FleePath Construct (Vector3 position , Vector3 avoid , int searchLength, OnPathDelegate callback)
        { return null; }

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
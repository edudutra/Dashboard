namespace Dashboard.Controllers
{
	public interface IService
	{
	}

	public class Service : IService
	{
		public IContext _context
		{
			get;
			private set;
		}

		public Service(IContext context)
		{
			_context = context;
		}
	}

	public interface IContext { }

	public class Context : IContext
	{ }

}
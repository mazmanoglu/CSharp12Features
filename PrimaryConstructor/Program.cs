// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors?source=docs

using Microsoft.AspNetCore.Mvc;
using PrimaryConstructor;

Console.WriteLine("Hello, World!");

// old style primary constructor
public readonly struct OldDistance
{
	public readonly double Magnitude { get; }
	public readonly double Distance { get; }

	public OldDistance(double dx, double dy)
	{
		Magnitude = Math.Sqrt(dx * dx + dy * dy);
		Distance = Math.Atan2(dx, dy);
	}
}
// the new features make it easy to use field initializers when you need arguments to initialize a field or property

// new style primary constructor --- Initialize property
public readonly struct Distance(double dx, double dy)
{
	public readonly double Magnitude { get; } = Math.Sqrt(dx * dx + dy * dy);
	public readonly double Direction { get; } = Math.Atan2(dx, dy);
}

//new primary constructor with extra methods --- Create mutable state

public struct NewDistance(double dtx, double dty)
{
	public readonly double Magnitude { get; } = Math.Sqrt(dtx * dtx + dty * dty);
	public readonly double Direction { get; } = Math.Atan2(dtx, dty);

	public void Translate(double deltaX, double deltaY)
	{
		dtx += deltaX;
		dty += deltaY;
	}
	public NewDistance() : this(5, 6) { }
}


// new primary constructor --- Dependency Injection
public interface IService
{
	Distance GetDistance();
}

public class ExampleController(IService service) : ControllerBase
{
	[HttpGet]
	public ActionResult<Distance> Get()
	{
		return service.GetDistance();
	}
}



using System;

public interface IProduct : IEntity
{
	string Name { get; set; }

    string Description { get; set; }
}

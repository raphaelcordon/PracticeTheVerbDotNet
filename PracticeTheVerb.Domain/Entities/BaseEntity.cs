﻿namespace PracticeTheVerb.Domain.Entities;

public class BaseEntity
{
	protected BaseEntity()
	{
		Id = Guid.NewGuid();
	}

	public Guid Id { get; private set; }
}

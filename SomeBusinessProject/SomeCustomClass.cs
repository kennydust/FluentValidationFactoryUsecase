using FluentValidation;
using System;

namespace SomeBusinessProject
{
	public class SomeCustomClass 
	{
		public string email { get; set; }
	}

	public class SomeCustomClassValidator : AbstractValidator<SomeCustomClass>
	{
		public SomeCustomClassValidator()
		{
			RuleFor(x => x.email).NotEmpty();
		}
	}
}

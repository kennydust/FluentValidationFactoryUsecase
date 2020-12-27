using FluentValidation;
using System;

namespace SomeBusinessProject
{
	public class SomeBusinessServiceCode : ISomeBusinessServiceCode
	{
		private readonly IValidatorFactory _validatorFactory;

		public SomeBusinessServiceCode(IValidatorFactory validatorFactory)
		{
			_validatorFactory = validatorFactory;
		}

		public void SomeMethod() 
		{
			var validator = _validatorFactory.GetValidator<SomeCustomClassValidator>();
			if (validator == null)
				throw new NotImplementedException();

			//validator.Validate(new SomeCustomClass());
			Console.WriteLine("we ok");
		}
	}

	public interface ISomeBusinessServiceCode
	{
		void SomeMethod();
	}
}

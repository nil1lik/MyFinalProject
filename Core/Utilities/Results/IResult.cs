using System;
namespace Core.Utilities.Results
{
	//Temel voidler için başlangıç
	public interface IResult
	{
		bool Success { get; } //constructor ile set edilir 
		string Message { get; }

	}
}


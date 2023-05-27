using System;
using L4764;
using System.Collections.Generic;

namespace L4764
{
	public class Results
	{
		public List<Result> Answers;
		public Results()
		{
			Answers = new List<Result>();
		}

		public bool AddAnswer ( Result result)
		{
			if (result.IsInvalid)
				return true;
			else
				Answers.Add(result);

				return false;

		}
	}
}


using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Employee : ICloneable
    {
		private List<string> empList;

		public Employee()
		{
			empList = new List<string>();
		}

		public Employee(List<string> list)
		{
			this.empList = list;
		}
		public void loadData()
		{
			empList.Add("Pooja");
			empList.Add("Ankit");
			empList.Add("Prasad");
			empList.Add("Arti");
		}

		public List<string> getEmpList()
		{
			return empList;
		}

		
	public Object Clone() 
		{
			List<string> temp = new List<string>();
			////List<>
			////foreach (string o in temp)
			////{
			////	temp.Add(getEmpList());
			////}
			////return new Employee(temp);
			for (string s : this.getEmpList())
			{
				temp.add(s);
			}
		}
    }
}

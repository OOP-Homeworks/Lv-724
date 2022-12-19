

			try
			{
				Console.WriteLine("Input two double numbers");
				Console.Write("First number : ");
				double firstNumber = Convert.ToDouble(Console.ReadLine());
				Console.Write("Second number : ");
				double secondNumber = Convert.ToDouble(Console.ReadLine());
				if (firstNumber > secondNumber)
				{
					throw new Exception("Second number must be bigger than first number");
				}
				if (secondNumber == 0)
				{
					throw new DivideByZeroException();
				}
				Console.WriteLine("{0} / {1} = {2}", secondNumber, firstNumber, secondNumber / firstNumber);
			}
			catch (FormatException exeption)
			{
				Console.WriteLine(exeption.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine("Not sorted list : ");
			List<IDeveloper> devList = new List<IDeveloper>();
			devList.Add(new Programmer("Stas", "C#"));
			devList.Add(new Builder("Slavik", "Java"));
			devList.Add(new Programmer("Anna", "C++"));
			devList.Add(new Builder("Messi", "C#"));
			devList.Add(new Programmer("Nastya", "C#"));
			devList.Add(new Builder("Ihor", "JS"));

			foreach (IDeveloper dev in devList)
			{
				dev.Create();
				dev.Destroy();
			}
			Console.WriteLine("");
			Console.WriteLine("Sorted list : ");

			devList.Sort();
			foreach (IDeveloper dev in devList)
			{
				dev.Create();
				dev.Destroy();
			}
			Console.WriteLine("");

			Dictionary<uint, string> values = new Dictionary<uint, string>();
			Console.WriteLine("Please, input 7 values and IDs");
			for (int i = 0; i < 7; i++)
			{
				Console.Write("Name : ");
				string name = Console.ReadLine();
				Console.Write("ID : ");
				uint ID = uint.Parse(Console.ReadLine());
				values.Add(ID, name);
			}
			Console.WriteLine("Please, input ID for the find name : ");
			uint id = uint.Parse(Console.ReadLine());
			bool find = true;
			foreach (KeyValuePair<uint, string> keyValue in values)
			{
				if (keyValue.Key == id)
				{
					Console.WriteLine($"ID = {keyValue.Key} equals {keyValue.Value}");
					find = true;
				}
			}
			if (!find)
			{
				Console.WriteLine("Mistake");
			}

namespace BlazorWebApplication1
{
	public class Pets
	{
		public Pets(string petId, string name)
		{
			PetId = petId;
			Name = name;
		}

		public string PetId { get; set; }
		public string Name { get; set; }

	}
}

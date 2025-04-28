using System.Reflection.Metadata;

namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumber(object sender, EventArgs e)
	{
		NameApp.IsVisible = false;
		ContainerLuckNumbers.IsVisible = true;

		// Fazendo a atribuição dos numeros
		var list = GenerateLuckNumbers();

		LuckNumber01.Text = list.ElementAt(0).ToString("D2");
		LuckNumber02.Text = list.ElementAt(1).ToString("D2");
		LuckNumber03.Text = list.ElementAt(2).ToString("D2");
		LuckNumber04.Text = list.ElementAt(3).ToString("D2");
		LuckNumber05.Text = list.ElementAt(4).ToString("D2");
		LuckNumber06.Text = list.ElementAt(5).ToString("D2");
	}

	// Método de geranção de números randomicos
	private SortedSet<int> GenerateLuckNumbers()
	{
		// Usar o HashSet para não repetir os números
		var list = new SortedSet<int>();

		while(list.Count < 6)
		{
            var random = new Random();
            var luckNumber = random.Next(1, 60);

			list.Add(luckNumber);
        }

		return list;
		
	}

}
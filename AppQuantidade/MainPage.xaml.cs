using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
	public partial class MainPage : ContentPage
	{
		int quantidade = 1;

		public MainPage()
		{
			InitializeComponent();
		}

		void Aumentar(System.Object sender, System.EventArgs e)
		{
			quantidade++;
			LblQuantidade.Text = quantidade.ToString();
		}

		void Diminuir(System.Object sender, System.EventArgs e)
		{
			if (quantidade != 0)
			{
				quantidade--;
				LblQuantidade.Text = quantidade.ToString();
			}
		}
	}
}

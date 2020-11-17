using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace karusel
{
	public partial class MainPage : CarouselPage
	{

		public MainPage()
		{
			//--------------------------------------------------------
			var holerContentPage = new ContentPage // название - холерик
			{
				Content = new StackLayout
				{
					BackgroundColor = Color.Red,
			        Children =
				{
			new Label
			{
				Text = "Холерик", // текст
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
		},

			new Image
			{
				Source = "holer.jpg",

			},

						
						}
					}
			};

			// -----------------------------------------------------------
			var sangContentPage = new ContentPage // название - сангвиник
			{
				BackgroundColor = Color.LightYellow,
				Content = new StackLayout
				{
					Children =
					{
					 new Label
						{
							Text = "Сангвиник", // текст
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center
						},

						new Image
						{
							Source="sang.jpg",
						
						},
					}
				}
			};

			//------------------------------------------------------------------
			var plegmContentPage = new ContentPage // название - флегматик
			{
				Content = new StackLayout
				{
					BackgroundColor = Color.Gray,
					Children =
					{
						new Label
						{
							Text = "Флегматик", // текст
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center
						},

	               	    new Image
		               {
                            Source = "plegm.jpg"
		               }
				}
			}
		};

			//-------------------------------------------------------------------
			var melanhContentPage = new ContentPage // название - меланхолик
			{
				BackgroundColor = Color.LightBlue,
				Content = new StackLayout
				{
					Children =
					{
						new Label
						{
							Text = "Меланхолик", // текст
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center
						},

						new Image
						{
							Source="melanh.jpg",
						},
					}
				}
			};
			Children.Add(holerContentPage);
			Children.Add(sangContentPage);
			Children.Add(plegmContentPage);
			Children.Add(melanhContentPage);
		}
	}
}

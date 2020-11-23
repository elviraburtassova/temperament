using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace karusel
{
	public partial class MainPage : CarouselPage
	{
	    Image img1, img2, img3, img4, img5;
		Button btn1, btn2, btn3, btn4, btn5;

		public MainPage()
		{
			//--------------------------------------------------------
			img1 = new Image
			{
				Source = "holer.jpg",

			};

			btn1 = new Button
			{
				BackgroundColor = Color.LightPink,
				TextColor = Color.DarkRed,
				Text = "О холериках",
			};
			btn1.Clicked += Btn1_Clicked;	

			var holerContentPage = new ContentPage // название - холерик
			{
				Content = new StackLayout
				{
					BackgroundColor = Color.Red,
					Children =
					{
						{
							new Label
							{
								Text = "Холерик",
								TextColor= Color.DarkRed,// текст
								FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
								HorizontalOptions = LayoutOptions.Center
							}
						}
					}
				}
			};

			// -----------------------------------------------------------
			img2 = new Image
			{
				Source = "sang.jpg",
			};

			btn2 = new Button
			{
				BackgroundColor = Color.GreenYellow,
				TextColor = Color.LightGreen,
				Text = "О сангвиниках",
			};
			btn2.Clicked += Btn2_Clicked;

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
							TextColor= Color.Yellow,
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center
						},
					}
				}
			};

			//------------------------------------------------------------------
			img3 = new Image
			{
				Source = "plegm.jpg"
			};

			btn3 = new Button
			{
				BackgroundColor = Color.GreenYellow,
				TextColor = Color.LightGreen,
				Text = "О флегматиках"
			};
			btn3.Clicked += Btn3_Clicked;

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
							TextColor= Color.Black,
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center
						},
				}
				}
			};

			//-------------------------------------------------------------------
			img4 = new Image
			{
				Source = "melanh.jpg",
			};

			btn4 = new Button
			{
				BackgroundColor = Color.GreenYellow,
				TextColor = Color.LightGreen,
				Text = "О меланхоликах"
			};
			btn4.Clicked += Btn4_Clicked;

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
							TextColor= Color.Blue,
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center
						},
					}
				}
			};

			//---------------------------------------------------------------
			img5 = new Image
			{
				Source = "temp.jpg",
			};

			btn5 = new Button
			{
				BackgroundColor = Color.PeachPuff,
				TextColor = Color.HotPink,
				Text = "Ссылка на тест"
			};
			btn5.Clicked += Btn5_Clicked;

			var testContentPage = new ContentPage // название - меланхолик
			{
				BackgroundColor = Color.LightPink,
				Content = new StackLayout
				{
					Children =
					{
						new Label
						{
							Text = "Пройти тест на типы температмента можно по ссылке ниже", // текст
							TextColor= Color.HotPink,
							FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center
						},
					}
				}
			};
			Children.Add(holerContentPage);
			Children.Add(sangContentPage);
			Children.Add(plegmContentPage);
			Children.Add(melanhContentPage);
			Children.Add(testContentPage);


		}

		private async void Btn5_Clicked(object sender, EventArgs e)
		{
			Uri uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
			await Browser.OpenAsync(uri);
		}

		private async void Btn4_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("Дополнительная информация", "Человека меланхолического темперамента можно охарактеризовать как легкоранимого, склонного глубоко переживать даже незначительные трудности и неудачи, но внешне вяло реагирующего на окружающее. Меланхолики отличаются высокой сенситивностью и эмоциональной чувствительностью, как следствие возникает легкоранимость. В некоторых сферах деятельности это является желательной личностной чертой, так как высокая эмоциональная чувствительность людей с меланхолическим темпераментом позволяет улавливать тончайшие эмоциональные выражения окружающих, особенно утончённых личностей. Для меланхоликов также характерно преобладание подавленного настроения и слабость волевой деятельности, проявляющаяся, например, в неуверенности в себе и нерешительности. При неблагоприятных условиях у них может развиться повышенная эмоциональная ранимость, замкнутость, отчуждённость.В спокойной, привычной для них обстановке, меланхолики могут успешно справляться с жизненными задачами.", "Скрыть");
		}

		private async void Btn3_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("Дополнительная информация", "У флегматика преобладает спокойное, ровное настроение; его чувства и эмоции обычно отличаются постоянством. Флегматик трудно переключается с одного вида деятельности на другой и приспосабливается к новой обстановке. Характерно то, что новые формы поведения у флегматика вырабатываются медленно, но долго сохраняются. Он редко выходит из себя, не склонен к конфликтам; ему свойственны ровность, спокойствие, выдержка, иногда вялость, безразличие к окружающим, лень. Павлов относил данный тип темперамента к сильному типу.", "Скрыть");
		}

		private async void Btn2_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("Дополнительная информация", "Сангвиник — это личность, характеризующаяся высокой психической активностью, энергичностью, работоспособностью, быстротой и живостью движений, разнообразием и богатством мимики, быстрым темпом речи. Сангвиник стремится к частой смене впечатлений, легко и быстро отзывается на окружающие события, общителен. Эмоции у сангвиника преимущественно положительные, они быстро возникают и быстро сменяются. Он быстро приспосабливается к новым условиям и быстро сходится с людьми. Его чувства легко возникают и сменяются новыми, ему свойственна выразительность, но иногда и непостоянство.", "Скрыть");
		}

		private async void Btn1_Clicked(object sender, EventArgs e)
		{
			await DisplayAlert("Дополнительная информация", "Холерик — это субъект, обладающий одним из четырёх основных типов темперамента, характеризующийся высоким уровнем психической активности, энергичностью действий, резкостью, стремительностью, силой движений, их быстрым темпом, порывистостью. Холерик вспыльчив, нетерпелив, подвержен эмоциональным срывам, иногда бывает агрессивным.", "Скрыть");
		}
	}
}

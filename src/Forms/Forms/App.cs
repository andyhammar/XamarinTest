using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLib;
using Xamarin.Forms;

namespace Forms
{
    public class App
    {
        public static Page GetMainPage()
        {
            var textBlock = new Label()
            {
            };

            var progress = new ProgressBar()
            {
                IsVisible = false,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            return new ContentPage
            {
                //Content = new Label
                //{
                //    Text = "Hello, Forms !",
                //    VerticalOptions = LayoutOptions.CenterAndExpand,
                //    HorizontalOptions = LayoutOptions.CenterAndExpand,
                //},

                
                Content = new StackLayout()
                {
                    Children =
                    {
                        new Label()
                        {
                          Text = "F O R M S",
                          Font = Font.SystemFontOfSize(24),
                          VerticalOptions = LayoutOptions.Start,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,

                        },
                        new Button()
                        {
                            Text = "get word",
                            Command = new Command(async () =>
                            {
                                progress.IsVisible = true;
                                var fetcher = new WebFetcher();
                                var word = await fetcher.GetWord();
                                textBlock.Text = word;
                                progress.IsVisible = false;
                            })
                        },
                        progress,
                        textBlock
                    }
                }
            };
        }
    }
}

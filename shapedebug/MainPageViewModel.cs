using System.Collections.Generic;
using Xamarin.Forms;

namespace shapedebug
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            CarouselItems = new List<CarouselItem>
            {
                new CarouselItem("Page 1"),
                new CarouselItem("Page 2"),
                new CarouselItem("Page 3"),
                new CarouselItem("Page 4"),
                new CarouselItem("Page 5"),
            };
        }

        public List<CarouselItem> CarouselItems { get; }
    }

    public class CarouselItem
    {
        public CarouselItem(string title)
        {
            TopView = new TopView(title);
        }
        public View TopView { get; }
    }
}

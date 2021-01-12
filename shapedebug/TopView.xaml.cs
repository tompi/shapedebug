using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shapedebug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopView
    {
        public TopView(string text)
        {
            InitializeComponent();
            GreenLabel.Text = text;
        }
    }
}
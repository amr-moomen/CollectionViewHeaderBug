using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace collectionViewHeader
{
    public class MobileNasoption
    {
        public string ItemTitle { get; set; }
        public string ItemImageURL { get; set; }

    }
    public partial class MainPage : ContentPage
    {
        IEnumerable ItemsSource1;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            ItemsSource1 = new List<MobileNasoption>() {
                new MobileNasoption{ItemTitle="Directory", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="My Profile", ItemImageURL="a2.png" },
                new MobileNasoption{ItemTitle= "Approvel", ItemImageURL="a3.png" },
                new MobileNasoption{ItemTitle="Benefit", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="My Leavs", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="approval", ItemImageURL="a6.png" },
                new MobileNasoption{ItemTitle="Expense", ItemImageURL="a7.png" },
                new MobileNasoption{ItemTitle="My Time", ItemImageURL="a8.png" },
                new MobileNasoption{ItemTitle="Attendance ", ItemImageURL="a9.png" },
                new MobileNasoption{ItemTitle="Sign in", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="permisions", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="Benefit", ItemImageURL="a2.png" },        
                new MobileNasoption{ItemTitle="Items", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="Leavs", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="permisions", ItemImageURL="a8.png" },
            };
        }
        protected override void OnAppearing()
        {
            CollectionView.ItemsSource = ItemsSource1;
        }
        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void RTLClicked(object sender, EventArgs e)
        {
            this.FlowDirection = FlowDirection.RightToLeft;
            titleHeader.Text = "مرحبا عمرو حسنى";
            ItemsSource1 = new List<MobileNasoption>() {
                new MobileNasoption{ItemTitle="ملفاتى", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="حسابى", ItemImageURL="a2.png" },
                new MobileNasoption{ItemTitle=" الحاله", ItemImageURL="a3.png" },
                new MobileNasoption{ItemTitle="الامتيازات", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="اجازانى", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle=" الاذونات", ItemImageURL="a6.png" },
                new MobileNasoption{ItemTitle= "المصاريف", ItemImageURL="a7.png" },
                new MobileNasoption{ItemTitle="اذوناتى", ItemImageURL="a8.png" },
                new MobileNasoption{ItemTitle=" الاجازات", ItemImageURL="a9.png" },
                new MobileNasoption{ItemTitle="اجازانى", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="ملفاتى", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="حسابى", ItemImageURL="a2.png" },
                new MobileNasoption{ItemTitle="الامتيازات", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="اجازانى", ItemImageURL="a5.png" },   
                new MobileNasoption{ItemTitle="اذوناتى", ItemImageURL="a8.png" },
            };
            CollectionView.ItemsSource = ItemsSource1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//include using below to use observable collection
using System.Collections.ObjectModel;

namespace pdc03_module02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity5 : ContentPage
    {
        ObservableCollection<employee> employees= new ObservableCollection<employee>();
        public ObservableCollection<employee> Employees { get { return employees; } }
        
        public activity5()
        {
            InitializeComponent();
            {
                lst.ItemsSource = employees;
                employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position = "President", profileImage= "image1.jpg" });
                employees.Add(new employee { DisplayName = "Juana", Position = "Vice President", profileImage = "image2.jpg" });
                employees.Add(new employee { DisplayName = "Juano", Position = "Secretary", profileImage = "image3.jpg" });
                //employees.Add(new employee { DisplayName = "Juani", Position = "Muse", profileImage = "https://www.google.com.ph/imgres?imgurl=https%3A%2F%2Fd2qp0siotla746.cloudfront.net%2Fimg%2Fuse-cases%2Fprofile-picture%2Ftemplate_3.jpg&imgrefurl=https%3A%2F%2Fsnappa.com%2Fcreate%2Fprofile-pictures&tbnid=NBYRs7in3sRCxM&vet=12ahUKEwiF_NirzL79AhVogFYBHSLLBFwQMygNegUIARDdAQ..i&docid=IMQD_FqAsNjIYM&w=1000&h=1000&q=picture&hl=en&ved=2ahUKEwiF_NirzL79AhVogFYBHSLLBFwQMygNegUIARDdAQ.jpg" });
            }
        }
    }
    }

using System.Collections.ObjectModel;
using System.Windows;

namespace ShinyLine2WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ShineLineVm> Lines { get; set; } 

        public MainWindow()
        {
            InitializeComponent();
            Lines = new ObservableCollection<ShineLineVm>();
            DataContext = this;

            Lines.Add(new ShineLineVm
            {
                X1 = 130,
                Y1 = 120,
                X2 = 400,
                Y2 = 200
            });
        }
    }
}

using System;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Windows;

namespace ShinyLine2WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ShineLineVm> Lines { get; set; }

        private RandomNumberGenerator _randomGenerator;

        public MainWindow()
        {
            InitializeComponent();

            _randomGenerator = RandomNumberGenerator.Create();
            Lines = new ObservableCollection<ShineLineVm>();
            DataContext = this;

            for (var i = 0; i < 50; i++)
            {
                Lines.Add(CreateRandomLine());
            }
        }

        private ShineLineVm CreateRandomLine()
        {


            var line = new ShineLineVm
            {
                X1 = (int)(NextDouble() * this.Width * 0.8 + this.Width * 0.1),
                Y1 = (int)(NextDouble() * this.Height * 0.8 + this.Height * 0.1),
                X2 = (int)(NextDouble() * this.Width * 0.8 + this.Width * 0.1),
                Y2 = (int)(NextDouble() * this.Height * 0.8 + this.Height * 0.1),
            };
            return line;
        }

        private double NextDouble()
        {
            var buff = new byte[4];
            _randomGenerator.GetBytes(buff);
            return (double)BitConverter.ToUInt32(buff, 0) / UInt32.MaxValue;
        }
    }
}

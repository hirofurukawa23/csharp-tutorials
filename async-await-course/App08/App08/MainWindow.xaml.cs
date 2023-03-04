using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace App08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //同期処理のボタン
        private void Button_Click_Sync(object sender, RoutedEventArgs e)
        {
            ClearMessage();
            DoHeavyWork();
            DisplayDoneMessage();
        }

        //非同期処理のボタン
        private async void Button_Click_Async(object sender, RoutedEventArgs e)
        {
            ClearMessage();
            await Task.Run(() => DoHeavyWork());
            DisplayDoneMessage();
        }

        //クリアボタン
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            ClearMessage();
        }

        private void ClearMessage()
            => this.Message.Text = string.Empty;

        private void DisplayDoneMessage()
            => this.Message.Text = "終了しました。";

        private void DoHeavyWork()
        {
            Thread.Sleep(3000);
        }
    }
}

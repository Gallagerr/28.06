using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _28._06
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      try
      {
        var hostEntry = Dns.GetHostEntry(textbox.Text);

        if (textbox.Text == hostEntry.HostName)
        {
          StringBuilder message = new StringBuilder();
          foreach (var addres in hostEntry.AddressList)
          {
            message.Append(addres.ToString());
          }
          MessageBox.Show(message.ToString());
        }
        else
        {
          label.Content = ("IP принадлежит:  " + hostEntry.HostName);
        }
      }
      catch
      {
        MessageBox.Show("Нечего не найден");
      }
    }
  }
}

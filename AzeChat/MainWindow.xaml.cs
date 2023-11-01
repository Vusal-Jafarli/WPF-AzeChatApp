using AzeChat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace AzeChat
{
    public partial class MainWindow : Window
    {
        public List<Message> messages_user_1 { get; set; }
        public List<Message> messages_user_2 { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            messages_user_1 = new List<Message>()
            {
                new Message("Hi",new DateTime(2023,10,28,15,34,10)),
                new Message("What's up?",new DateTime(2023,10,28,15,35,20)),
                new Message("Where r u?",new DateTime(2023,10,28,15,38,10)),
                new Message("Go out",new DateTime(2023,10,28,15,40,10)),
                new Message("I'm coming",new DateTime(2023,10,28,15,42,10)),
                new Message("Oke",new DateTime(2023,10,28,15,49,10))
            };


            messages_user_2 = new List<Message>()
            {
                new Message("Hi",new DateTime(2023,10,28,15,35,10)),
                new Message("Well, you?",new DateTime(2023,10,28,15,35,40)),
                new Message("At home",new DateTime(2023,10,28,15,40,10)),
                new Message("Good offer",new DateTime(2023,10,28,15,41,10)),
                new Message("Okayyy",new DateTime(2023,10,28,15,40,10))
            };


            DataContext = this;
        }
    }
}

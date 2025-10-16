using System.Windows.Controls;


namespace TalkCtrlLibrary
{
    /// <summary>
    /// Interaction logic for MessageItem.xaml
    /// </summary>
    public partial class MessageItem : UserControl
    {
        public object Nickname
        {
            get => NicknameView.Content;
            set { NicknameView.Content = value; }
        }

        public string Message
        {
            get => MsgContentView.Text;
            set { MsgContentView.Text = value; }
        }

        public object Time
        {
            get => TimeView.Content;
            set => TimeView.Content = value;
        }

        public MessageItem()
        {
            InitializeComponent();
        }
    }

}

using System.Windows.Controls;


namespace TalkCtrlLibrary
{
    /// <summary>
    /// RightMessageItem.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RightMessageItem : UserControl
    {
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

        public RightMessageItem()
        {
            InitializeComponent();
        }
    }
}

using System.Windows.Controls;


namespace TalkCtrlLibrary
{
    /// <summary>
    /// DateBadgeItem.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DateBadgeItem : UserControl
    {
        public string Date
        {
            get => DateTextView.Text;
            set => DateTextView.Text = "📅 " + value;
        }

        public DateBadgeItem()
        {
            InitializeComponent();
        }
    }
}

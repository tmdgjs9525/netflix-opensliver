using System.Windows;
using System.Windows.Controls;

namespace netflix_opensliver.Units
{
    public partial class CustomTextBox : TextBox
    {
        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(int), typeof(CustomTextBox), new PropertyMetadata(0));

      


        public CustomTextBox()
        {
            this.InitializeComponent();
        }
    }
}

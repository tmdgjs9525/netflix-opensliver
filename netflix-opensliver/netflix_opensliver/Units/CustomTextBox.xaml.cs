using System.Windows;
using System.Windows.Controls;

namespace netflix_opensliver.Units
{
    public partial class CustomTextBox : TextBox
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CustomTextBox), new PropertyMetadata(new CornerRadius(0)));

      


        public CustomTextBox()
        {
            this.InitializeComponent();
        }
    }
}

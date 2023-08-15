using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TextBoxWithHint.Controls
{
    public class TextBoxWithHint : TextBox
    {

        public TextBoxWithHint()
        {
            TextChanged += (sender, e) =>
            {
                if (String.IsNullOrEmpty(Text))
                {
                    VisableHint = Visibility.Visible;
                }
                else
                {
                    VisableHint = Visibility.Hidden;
                }
            };
            
        }


        public Visibility VisableHint
        {
            get { return (Visibility)GetValue(VisableHintProperty); }
            set { SetValue(VisableHintProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VisableHint.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VisableHintProperty =
            DependencyProperty.Register("VisableHint", typeof(Visibility), typeof(TextBoxWithHint), new PropertyMetadata(Visibility.Visible));



        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Hint.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HintProperty =
            DependencyProperty.Register("Hint", typeof(string), typeof(TextBoxWithHint), new PropertyMetadata(""));




        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(TextBoxWithHint), new PropertyMetadata(new CornerRadius(0)));



        static TextBoxWithHint()
        {

            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextBoxWithHint), new FrameworkPropertyMetadata(typeof(TextBoxWithHint)));
        }

    }
}

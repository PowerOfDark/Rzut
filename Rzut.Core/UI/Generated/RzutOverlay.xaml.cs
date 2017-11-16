// -----------------------------------------------------------
//  
//  This file was generated, please do not modify.
//  
// -----------------------------------------------------------
namespace EmptyKeys.UserInterface.Generated {
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using EmptyKeys.UserInterface;
    using EmptyKeys.UserInterface.Charts;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Input;
    using EmptyKeys.UserInterface.Interactions.Core;
    using EmptyKeys.UserInterface.Interactivity;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Effects;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "3.0.0.0")]
    public partial class RzutOverlay : UIRoot {
        
        private Grid e_0;
        
        private Border e_1;
        
        private Grid e_2;
        
        private ListBox list;
        
        private TextBlock e_9;
        
        public RzutOverlay() : 
                base() {
            this.Initialize();
        }
        
        public RzutOverlay(int width, int height) : 
                base(width, height) {
            this.Initialize();
        }
        
        private void Initialize() {
            Style style = RootStyle.CreateRootStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            this.Background = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.Background.Opacity = 0F;
            // e_0 element
            this.e_0 = new Grid();
            this.Content = this.e_0;
            this.e_0.Name = "e_0";
            ColumnDefinition col_e_0_0 = new ColumnDefinition();
            col_e_0_0.Width = new GridLength(0.8F, GridUnitType.Star);
            this.e_0.ColumnDefinitions.Add(col_e_0_0);
            ColumnDefinition col_e_0_1 = new ColumnDefinition();
            col_e_0_1.Width = new GridLength(0.2F, GridUnitType.Star);
            this.e_0.ColumnDefinitions.Add(col_e_0_1);
            // e_1 element
            this.e_1 = new Border();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_1.BorderThickness = new Thickness(2F, 2F, 2F, 2F);
            Grid.SetColumn(this.e_1, 1);
            // e_2 element
            this.e_2 = new Grid();
            this.e_1.Child = this.e_2;
            this.e_2.Name = "e_2";
            this.e_2.Opacity = 0.7F;
            this.e_2.Background = new SolidColorBrush(new ColorW(119, 136, 153, 255));
            RowDefinition row_e_2_0 = new RowDefinition();
            row_e_2_0.Height = new GridLength(0.9F, GridUnitType.Star);
            this.e_2.RowDefinitions.Add(row_e_2_0);
            RowDefinition row_e_2_1 = new RowDefinition();
            row_e_2_1.Height = new GridLength(0.1F, GridUnitType.Star);
            this.e_2.RowDefinitions.Add(row_e_2_1);
            // list element
            this.list = new ListBox();
            this.e_2.Children.Add(this.list);
            this.list.Name = "list";
            Func<UIElement, UIElement> list_dtFunc = list_dtMethod;
            this.list.ItemTemplate = new DataTemplate(list_dtFunc);
            this.list.SelectedIndex = -1;
            Grid.SetRow(this.list, 0);
            Binding binding_list_ItemsSource = new Binding("Balls");
            this.list.SetBinding(ListBox.ItemsSourceProperty, binding_list_ItemsSource);
            // e_9 element
            this.e_9 = new TextBlock();
            this.e_2.Children.Add(this.e_9);
            this.e_9.Name = "e_9";
            this.e_9.Text = "Tutaj będą przyciski xd";
            Grid.SetRow(this.e_9, 1);
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Regular, "Segoe_UI_15_Regular");
            FontManager.Instance.AddFont("Segoe UI", 16F, FontStyle.Regular, "Segoe_UI_12_Regular");
        }
        
        private static UIElement list_dtMethod(UIElement parent) {
            // e_3 element
            Border e_3 = new Border();
            e_3.Parent = parent;
            e_3.Name = "e_3";
            e_3.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_3.BorderThickness = new Thickness(2F, 2F, 2F, 2F);
            // e_4 element
            StackPanel e_4 = new StackPanel();
            e_3.Child = e_4;
            e_4.Name = "e_4";
            e_4.Orientation = Orientation.Vertical;
            Binding binding_e_4_Background = new Binding("Data.ColorBrush");
            e_4.SetBinding(StackPanel.BackgroundProperty, binding_e_4_Background);
            // e_5 element
            Grid e_5 = new Grid();
            e_4.Children.Add(e_5);
            e_5.Name = "e_5";
            ColumnDefinition col_e_5_0 = new ColumnDefinition();
            col_e_5_0.Width = new GridLength(1F, GridUnitType.Auto);
            e_5.ColumnDefinitions.Add(col_e_5_0);
            ColumnDefinition col_e_5_1 = new ColumnDefinition();
            col_e_5_1.Width = new GridLength(1F, GridUnitType.Star);
            e_5.ColumnDefinitions.Add(col_e_5_1);
            ColumnDefinition col_e_5_2 = new ColumnDefinition();
            col_e_5_2.Width = new GridLength(1F, GridUnitType.Auto);
            e_5.ColumnDefinitions.Add(col_e_5_2);
            // e_6 element
            TextBlock e_6 = new TextBlock();
            e_5.Children.Add(e_6);
            e_6.Name = "e_6";
            e_6.FontSize = 20F;
            Grid.SetColumn(e_6, 0);
            Binding binding_e_6_Text = new Binding("LinearVelocityDisplay");
            e_6.SetBinding(TextBlock.TextProperty, binding_e_6_Text);
            // e_7 element
            TextBlock e_7 = new TextBlock();
            e_5.Children.Add(e_7);
            e_7.Name = "e_7";
            e_7.FontSize = 20F;
            Grid.SetColumn(e_7, 2);
            Binding binding_e_7_Text = new Binding("LinearVelocity");
            e_7.SetBinding(TextBlock.TextProperty, binding_e_7_Text);
            // e_8 element
            TextBlock e_8 = new TextBlock();
            e_4.Children.Add(e_8);
            e_8.Name = "e_8";
            e_8.FontSize = 16F;
            Grid.SetRow(e_8, 1);
            Binding binding_e_8_Text = new Binding("LinearVelocityDetails");
            e_8.SetBinding(TextBlock.TextProperty, binding_e_8_Text);
            return e_3;
        }
    }
}

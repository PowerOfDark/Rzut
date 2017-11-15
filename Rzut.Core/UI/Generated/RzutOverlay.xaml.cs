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
        
        private ScrollViewer e_3;
        
        private ItemsControl details;
        
        private TextBlock e_8;
        
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
            // e_3 element
            this.e_3 = new ScrollViewer();
            this.e_2.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            Grid.SetRow(this.e_3, 0);
            // details element
            this.details = new ItemsControl();
            this.e_3.Content = this.details;
            this.details.Name = "details";
            Func<UIElement, UIElement> details_iptFunc = details_iptMethod;
            ControlTemplate details_ipt = new ControlTemplate(details_iptFunc);
            this.details.ItemsPanel = details_ipt;
            Func<UIElement, UIElement> details_dtFunc = details_dtMethod;
            this.details.ItemTemplate = new DataTemplate(details_dtFunc);
            Binding binding_details_ItemsSource = new Binding("Balls");
            this.details.SetBinding(ItemsControl.ItemsSourceProperty, binding_details_ItemsSource);
            // e_8 element
            this.e_8 = new TextBlock();
            this.e_2.Children.Add(this.e_8);
            this.e_8.Name = "e_8";
            this.e_8.Text = "Tutaj będą przyciski xd";
            Grid.SetRow(this.e_8, 1);
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Regular, "Segoe_UI_15_Regular");
        }
        
        private static UIElement details_iptMethod(UIElement parent) {
            // e_4 element
            StackPanel e_4 = new StackPanel();
            e_4.Parent = parent;
            e_4.Name = "e_4";
            e_4.IsItemsHost = true;
            return e_4;
        }
        
        private static UIElement details_dtMethod(UIElement parent) {
            // e_5 element
            Border e_5 = new Border();
            e_5.Parent = parent;
            e_5.Name = "e_5";
            e_5.BorderThickness = new Thickness(2F, 2F, 2F, 2F);
            Binding binding_e_5_BorderBrush = new Binding("Data.ColorBrush");
            e_5.SetBinding(Border.BorderBrushProperty, binding_e_5_BorderBrush);
            // e_6 element
            StackPanel e_6 = new StackPanel();
            e_5.Child = e_6;
            e_6.Name = "e_6";
            e_6.Orientation = Orientation.Vertical;
            // e_7 element
            TextBlock e_7 = new TextBlock();
            e_6.Children.Add(e_7);
            e_7.Name = "e_7";
            e_7.FontSize = 20F;
            Binding binding_e_7_Text = new Binding("LinearVelocity");
            e_7.SetBinding(TextBlock.TextProperty, binding_e_7_Text);
            return e_5;
        }
    }
}

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
    public partial class DataEntryForm : UIRoot {
        
        private Grid e_0;
        
        private ItemsControl tabItems;
        
        private Border e_5;
        
        private Grid e_6;
        
        private TextBlock errors;
        
        private Button remove;
        
        private TextBlock e_7;
        
        private ScrollViewer entityEditor;
        
        private StackPanel e_8;
        
        private GroupBox e_9;
        
        private WrapPanel e_11;
        
        private Border e_12;
        
        private StackPanel e_13;
        
        private TextBlock e_14;
        
        private TextBox Radius;
        
        private Border e_15;
        
        private StackPanel e_16;
        
        private TextBlock e_17;
        
        private TextBox Mass;
        
        private Border e_18;
        
        private StackPanel e_19;
        
        private TextBlock e_20;
        
        private TextBox StartY;
        
        private Border e_21;
        
        private StackPanel e_22;
        
        private TextBlock e_23;
        
        private TextBox StartX;
        
        private Border e_24;
        
        private StackPanel e_25;
        
        private TextBlock e_26;
        
        private TextBox StartAngle;
        
        private Border e_27;
        
        private StackPanel e_28;
        
        private TextBlock e_29;
        
        private TextBox Velocity;
        
        private Border e_30;
        
        private StackPanel e_31;
        
        private TextBlock e_32;
        
        private TextBox AngularVelocity;
        
        private GroupBox e_33;
        
        private WrapPanel e_35;
        
        private Border e_36;
        
        private StackPanel e_37;
        
        private TextBlock e_38;
        
        private TextBox Restitution;
        
        private Border e_39;
        
        private StackPanel e_40;
        
        private TextBlock e_41;
        
        private TextBox AirResistance;
        
        private Border e_42;
        
        private StackPanel e_43;
        
        private TextBlock e_44;
        
        private TextBox AngularDrag;
        
        private GroupBox e_45;
        
        private WrapPanel e_47;
        
        private Border e_48;
        
        private StackPanel e_49;
        
        private TextBlock e_50;
        
        private TextBox GravitationalAcceleration;
        
        private Grid e_51;
        
        private StackPanel e_52;
        
        private ListBox color;
        
        private Grid e_55;
        
        private Rectangle e_56;
        
        private Rectangle preview;
        
        private Rectangle e_57;
        
        private Button add;
        
        private TextBlock e_58;
        
        private WrapPanel e_59;
        
        private TextBlock e_60;
        
        private CheckBox e_61;
        
        private WrapPanel e_62;
        
        private WrapPanel e_63;
        
        private Border e_64;
        
        private StackPanel e_65;
        
        private TextBlock e_66;
        
        private TextBox UnitRatio;
        
        private Button e_67;
        
        private TextBlock e_68;
        
        public DataEntryForm() : 
                base() {
            this.Initialize();
        }
        
        public DataEntryForm(int width, int height) : 
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
            this.Background = new SolidColorBrush(new ColorW(211, 211, 211, 255));
            InitializeElementResources(this);
            // e_0 element
            this.e_0 = new Grid();
            this.Content = this.e_0;
            this.e_0.Name = "e_0";
            RowDefinition row_e_0_0 = new RowDefinition();
            row_e_0_0.Height = new GridLength(0.08F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_0);
            RowDefinition row_e_0_1 = new RowDefinition();
            row_e_0_1.Height = new GridLength(0.1F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_1);
            RowDefinition row_e_0_2 = new RowDefinition();
            row_e_0_2.Height = new GridLength(0.67F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_2);
            RowDefinition row_e_0_3 = new RowDefinition();
            row_e_0_3.Height = new GridLength(0.15F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_3);
            // tabItems element
            this.tabItems = new ItemsControl();
            this.e_0.Children.Add(this.tabItems);
            this.tabItems.Name = "tabItems";
            Func<UIElement, UIElement> tabItems_iptFunc = tabItems_iptMethod;
            ControlTemplate tabItems_ipt = new ControlTemplate(tabItems_iptFunc);
            this.tabItems.ItemsPanel = tabItems_ipt;
            Func<UIElement, UIElement> tabItems_dtFunc = tabItems_dtMethod;
            this.tabItems.ItemTemplate = new DataTemplate(tabItems_dtFunc);
            Grid.SetRow(this.tabItems, 0);
            Binding binding_tabItems_ItemsSource = new Binding("Entities");
            this.tabItems.SetBinding(ItemsControl.ItemsSourceProperty, binding_tabItems_ItemsSource);
            // e_5 element
            this.e_5 = new Border();
            this.e_0.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.Margin = new Thickness(3F, 3F, 3F, 3F);
            this.e_5.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_5.BorderBrush = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            this.e_5.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetRow(this.e_5, 1);
            // e_6 element
            this.e_6 = new Grid();
            this.e_5.Child = this.e_6;
            this.e_6.Name = "e_6";
            this.e_6.Background = new SolidColorBrush(new ColorW(169, 169, 169, 255));
            ColumnDefinition col_e_6_0 = new ColumnDefinition();
            col_e_6_0.Width = new GridLength(0.9F, GridUnitType.Star);
            this.e_6.ColumnDefinitions.Add(col_e_6_0);
            ColumnDefinition col_e_6_1 = new ColumnDefinition();
            col_e_6_1.Width = new GridLength(0.1F, GridUnitType.Star);
            this.e_6.ColumnDefinitions.Add(col_e_6_1);
            // errors element
            this.errors = new TextBlock();
            this.e_6.Children.Add(this.errors);
            this.errors.Name = "errors";
            this.errors.HorizontalAlignment = HorizontalAlignment.Center;
            this.errors.VerticalAlignment = VerticalAlignment.Center;
            this.errors.Foreground = new SolidColorBrush(new ColorW(255, 0, 0, 255));
            this.errors.TextAlignment = TextAlignment.Center;
            Grid.SetColumn(this.errors, 0);
            // remove element
            this.remove = new Button();
            this.e_6.Children.Add(this.remove);
            this.remove.Name = "remove";
            Grid.SetColumn(this.remove, 1);
            // e_7 element
            this.e_7 = new TextBlock();
            this.remove.Content = this.e_7;
            this.e_7.Name = "e_7";
            this.e_7.FontSize = 30F;
            Binding binding_e_7_Text = new Binding("ButtonRemoveDisplay");
            this.e_7.SetBinding(TextBlock.TextProperty, binding_e_7_Text);
            // entityEditor element
            this.entityEditor = new ScrollViewer();
            this.e_0.Children.Add(this.entityEditor);
            this.entityEditor.Name = "entityEditor";
            Grid.SetRow(this.entityEditor, 2);
            // e_8 element
            this.e_8 = new StackPanel();
            this.entityEditor.Content = this.e_8;
            this.e_8.Name = "e_8";
            this.e_8.Orientation = Orientation.Vertical;
            // e_9 element
            this.e_9 = new GroupBox();
            this.e_8.Children.Add(this.e_9);
            this.e_9.Name = "e_9";
            Style e_9_s = new Style(typeof(GroupBox));
            Setter e_9_s_S_0 = new Setter(GroupBox.BorderThicknessProperty, new Thickness(5F));
            e_9_s.Setters.Add(e_9_s_S_0);
            Setter e_9_s_S_1 = new Setter(GroupBox.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_9_s.Setters.Add(e_9_s_S_1);
            Setter e_9_s_S_2 = new Setter(GroupBox.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_9_s.Setters.Add(e_9_s_S_2);
            Setter e_9_s_S_3 = new Setter(GroupBox.MarginProperty, new Thickness(10F));
            e_9_s.Setters.Add(e_9_s_S_3);
            this.e_9.Style = e_9_s;
            this.e_9.Background = new SolidColorBrush(new ColorW(169, 169, 169, 255));
            // e_10 element
            TextBlock e_10 = new TextBlock();
            e_10.Name = "e_10";
            e_10.Margin = new Thickness(10F, 10F, 10F, 10F);
            e_10.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_10.FontSize = 50F;
            e_10.FontStyle = FontStyle.Bold;
            Binding binding_e_10_Text = new Binding("ThrowParametersDisplay");
            e_10.SetBinding(TextBlock.TextProperty, binding_e_10_Text);
            this.e_9.Header = e_10;
            // e_11 element
            this.e_11 = new WrapPanel();
            this.e_9.Content = this.e_11;
            this.e_11.Name = "e_11";
            this.e_11.Orientation = Orientation.Horizontal;
            // e_12 element
            this.e_12 = new Border();
            this.e_11.Children.Add(this.e_12);
            this.e_12.Name = "e_12";
            Style e_12_s = new Style(typeof(Border));
            Setter e_12_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_12_s.Setters.Add(e_12_s_S_0);
            Setter e_12_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_12_s.Setters.Add(e_12_s_S_1);
            Setter e_12_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_12_s.Setters.Add(e_12_s_S_2);
            this.e_12.Style = e_12_s;
            // e_13 element
            this.e_13 = new StackPanel();
            this.e_12.Child = this.e_13;
            this.e_13.Name = "e_13";
            Style e_13_s = new Style(typeof(StackPanel));
            Setter e_13_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_13_s.Setters.Add(e_13_s_S_0);
            Setter e_13_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_13_s.Setters.Add(e_13_s_S_1);
            this.e_13.Style = e_13_s;
            // e_14 element
            this.e_14 = new TextBlock();
            this.e_13.Children.Add(this.e_14);
            this.e_14.Name = "e_14";
            this.e_14.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_14.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_14_Text = new Binding("RadiusDisplay");
            this.e_14.SetBinding(TextBlock.TextProperty, binding_e_14_Text);
            // Radius element
            this.Radius = new TextBox();
            this.e_13.Children.Add(this.Radius);
            this.Radius.Name = "Radius";
            this.Radius.Tag = "float";
            Binding binding_Radius_Text = new Binding("ActiveEntity.Radius");
            binding_Radius_Text.Mode = BindingMode.TwoWay;
            binding_Radius_Text.StringFormat = "{0:0.00}";
            this.Radius.SetBinding(TextBox.TextProperty, binding_Radius_Text);
            // e_15 element
            this.e_15 = new Border();
            this.e_11.Children.Add(this.e_15);
            this.e_15.Name = "e_15";
            Style e_15_s = new Style(typeof(Border));
            Setter e_15_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_15_s.Setters.Add(e_15_s_S_0);
            Setter e_15_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_15_s.Setters.Add(e_15_s_S_1);
            Setter e_15_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_15_s.Setters.Add(e_15_s_S_2);
            this.e_15.Style = e_15_s;
            // e_16 element
            this.e_16 = new StackPanel();
            this.e_15.Child = this.e_16;
            this.e_16.Name = "e_16";
            Style e_16_s = new Style(typeof(StackPanel));
            Setter e_16_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_16_s.Setters.Add(e_16_s_S_0);
            Setter e_16_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_16_s.Setters.Add(e_16_s_S_1);
            this.e_16.Style = e_16_s;
            // e_17 element
            this.e_17 = new TextBlock();
            this.e_16.Children.Add(this.e_17);
            this.e_17.Name = "e_17";
            this.e_17.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_17.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_17_Text = new Binding("MassDisplay");
            this.e_17.SetBinding(TextBlock.TextProperty, binding_e_17_Text);
            // Mass element
            this.Mass = new TextBox();
            this.e_16.Children.Add(this.Mass);
            this.Mass.Name = "Mass";
            this.Mass.Tag = "float";
            Binding binding_Mass_Text = new Binding("ActiveEntity.Mass");
            binding_Mass_Text.Mode = BindingMode.TwoWay;
            binding_Mass_Text.StringFormat = "{0:0.00}";
            this.Mass.SetBinding(TextBox.TextProperty, binding_Mass_Text);
            // e_18 element
            this.e_18 = new Border();
            this.e_11.Children.Add(this.e_18);
            this.e_18.Name = "e_18";
            Style e_18_s = new Style(typeof(Border));
            Setter e_18_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_18_s.Setters.Add(e_18_s_S_0);
            Setter e_18_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_18_s.Setters.Add(e_18_s_S_1);
            Setter e_18_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_18_s.Setters.Add(e_18_s_S_2);
            this.e_18.Style = e_18_s;
            // e_19 element
            this.e_19 = new StackPanel();
            this.e_18.Child = this.e_19;
            this.e_19.Name = "e_19";
            Style e_19_s = new Style(typeof(StackPanel));
            Setter e_19_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_19_s.Setters.Add(e_19_s_S_0);
            Setter e_19_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_19_s.Setters.Add(e_19_s_S_1);
            this.e_19.Style = e_19_s;
            // e_20 element
            this.e_20 = new TextBlock();
            this.e_19.Children.Add(this.e_20);
            this.e_20.Name = "e_20";
            this.e_20.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_20.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_20_Text = new Binding("StartYDisplay");
            this.e_20.SetBinding(TextBlock.TextProperty, binding_e_20_Text);
            // StartY element
            this.StartY = new TextBox();
            this.e_19.Children.Add(this.StartY);
            this.StartY.Name = "StartY";
            this.StartY.Tag = "float";
            Binding binding_StartY_Text = new Binding("ActiveEntity.StartY");
            binding_StartY_Text.Mode = BindingMode.TwoWay;
            binding_StartY_Text.StringFormat = "{0:0.00}";
            this.StartY.SetBinding(TextBox.TextProperty, binding_StartY_Text);
            // e_21 element
            this.e_21 = new Border();
            this.e_11.Children.Add(this.e_21);
            this.e_21.Name = "e_21";
            Style e_21_s = new Style(typeof(Border));
            Setter e_21_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_21_s.Setters.Add(e_21_s_S_0);
            Setter e_21_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_21_s.Setters.Add(e_21_s_S_1);
            Setter e_21_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_21_s.Setters.Add(e_21_s_S_2);
            this.e_21.Style = e_21_s;
            // e_22 element
            this.e_22 = new StackPanel();
            this.e_21.Child = this.e_22;
            this.e_22.Name = "e_22";
            Style e_22_s = new Style(typeof(StackPanel));
            Setter e_22_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_22_s.Setters.Add(e_22_s_S_0);
            Setter e_22_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_22_s.Setters.Add(e_22_s_S_1);
            this.e_22.Style = e_22_s;
            // e_23 element
            this.e_23 = new TextBlock();
            this.e_22.Children.Add(this.e_23);
            this.e_23.Name = "e_23";
            this.e_23.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_23.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_23_Text = new Binding("StartXDisplay");
            this.e_23.SetBinding(TextBlock.TextProperty, binding_e_23_Text);
            // StartX element
            this.StartX = new TextBox();
            this.e_22.Children.Add(this.StartX);
            this.StartX.Name = "StartX";
            this.StartX.Tag = "float";
            Binding binding_StartX_Text = new Binding("ActiveEntity.StartX");
            binding_StartX_Text.Mode = BindingMode.TwoWay;
            binding_StartX_Text.StringFormat = "{0:0.00}";
            this.StartX.SetBinding(TextBox.TextProperty, binding_StartX_Text);
            // e_24 element
            this.e_24 = new Border();
            this.e_11.Children.Add(this.e_24);
            this.e_24.Name = "e_24";
            Style e_24_s = new Style(typeof(Border));
            Setter e_24_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_24_s.Setters.Add(e_24_s_S_0);
            Setter e_24_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_24_s.Setters.Add(e_24_s_S_1);
            Setter e_24_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_24_s.Setters.Add(e_24_s_S_2);
            this.e_24.Style = e_24_s;
            // e_25 element
            this.e_25 = new StackPanel();
            this.e_24.Child = this.e_25;
            this.e_25.Name = "e_25";
            Style e_25_s = new Style(typeof(StackPanel));
            Setter e_25_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_25_s.Setters.Add(e_25_s_S_0);
            Setter e_25_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_25_s.Setters.Add(e_25_s_S_1);
            this.e_25.Style = e_25_s;
            // e_26 element
            this.e_26 = new TextBlock();
            this.e_25.Children.Add(this.e_26);
            this.e_26.Name = "e_26";
            this.e_26.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_26.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_26_Text = new Binding("StartAngleDisplay");
            this.e_26.SetBinding(TextBlock.TextProperty, binding_e_26_Text);
            // StartAngle element
            this.StartAngle = new TextBox();
            this.e_25.Children.Add(this.StartAngle);
            this.StartAngle.Name = "StartAngle";
            this.StartAngle.Tag = "float";
            Binding binding_StartAngle_Text = new Binding("ActiveEntity.StartAngle");
            binding_StartAngle_Text.Mode = BindingMode.TwoWay;
            binding_StartAngle_Text.StringFormat = "{0:0}";
            this.StartAngle.SetBinding(TextBox.TextProperty, binding_StartAngle_Text);
            // e_27 element
            this.e_27 = new Border();
            this.e_11.Children.Add(this.e_27);
            this.e_27.Name = "e_27";
            Style e_27_s = new Style(typeof(Border));
            Setter e_27_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_27_s.Setters.Add(e_27_s_S_0);
            Setter e_27_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_27_s.Setters.Add(e_27_s_S_1);
            Setter e_27_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_27_s.Setters.Add(e_27_s_S_2);
            this.e_27.Style = e_27_s;
            // e_28 element
            this.e_28 = new StackPanel();
            this.e_27.Child = this.e_28;
            this.e_28.Name = "e_28";
            Style e_28_s = new Style(typeof(StackPanel));
            Setter e_28_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_28_s.Setters.Add(e_28_s_S_0);
            Setter e_28_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_28_s.Setters.Add(e_28_s_S_1);
            this.e_28.Style = e_28_s;
            // e_29 element
            this.e_29 = new TextBlock();
            this.e_28.Children.Add(this.e_29);
            this.e_29.Name = "e_29";
            this.e_29.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_29.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_29_Text = new Binding("VelocityDisplay");
            this.e_29.SetBinding(TextBlock.TextProperty, binding_e_29_Text);
            // Velocity element
            this.Velocity = new TextBox();
            this.e_28.Children.Add(this.Velocity);
            this.Velocity.Name = "Velocity";
            this.Velocity.Tag = "float";
            Binding binding_Velocity_Text = new Binding("ActiveEntity.Velocity");
            binding_Velocity_Text.Mode = BindingMode.TwoWay;
            binding_Velocity_Text.StringFormat = "{0:0.00}";
            this.Velocity.SetBinding(TextBox.TextProperty, binding_Velocity_Text);
            // e_30 element
            this.e_30 = new Border();
            this.e_11.Children.Add(this.e_30);
            this.e_30.Name = "e_30";
            Style e_30_s = new Style(typeof(Border));
            Setter e_30_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_30_s.Setters.Add(e_30_s_S_0);
            Setter e_30_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_30_s.Setters.Add(e_30_s_S_1);
            Setter e_30_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_30_s.Setters.Add(e_30_s_S_2);
            this.e_30.Style = e_30_s;
            // e_31 element
            this.e_31 = new StackPanel();
            this.e_30.Child = this.e_31;
            this.e_31.Name = "e_31";
            Style e_31_s = new Style(typeof(StackPanel));
            Setter e_31_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_31_s.Setters.Add(e_31_s_S_0);
            Setter e_31_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_31_s.Setters.Add(e_31_s_S_1);
            this.e_31.Style = e_31_s;
            // e_32 element
            this.e_32 = new TextBlock();
            this.e_31.Children.Add(this.e_32);
            this.e_32.Name = "e_32";
            this.e_32.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_32.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_32_Text = new Binding("AngularVelocityDisplay");
            this.e_32.SetBinding(TextBlock.TextProperty, binding_e_32_Text);
            // AngularVelocity element
            this.AngularVelocity = new TextBox();
            this.e_31.Children.Add(this.AngularVelocity);
            this.AngularVelocity.Name = "AngularVelocity";
            this.AngularVelocity.Tag = "float";
            Binding binding_AngularVelocity_Text = new Binding("ActiveEntity.AngularVelocity");
            binding_AngularVelocity_Text.Mode = BindingMode.TwoWay;
            binding_AngularVelocity_Text.StringFormat = "{0:0.00}";
            this.AngularVelocity.SetBinding(TextBox.TextProperty, binding_AngularVelocity_Text);
            // e_33 element
            this.e_33 = new GroupBox();
            this.e_8.Children.Add(this.e_33);
            this.e_33.Name = "e_33";
            Style e_33_s = new Style(typeof(GroupBox));
            Setter e_33_s_S_0 = new Setter(GroupBox.BorderThicknessProperty, new Thickness(5F));
            e_33_s.Setters.Add(e_33_s_S_0);
            Setter e_33_s_S_1 = new Setter(GroupBox.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_33_s.Setters.Add(e_33_s_S_1);
            Setter e_33_s_S_2 = new Setter(GroupBox.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_33_s.Setters.Add(e_33_s_S_2);
            Setter e_33_s_S_3 = new Setter(GroupBox.MarginProperty, new Thickness(10F));
            e_33_s.Setters.Add(e_33_s_S_3);
            this.e_33.Style = e_33_s;
            this.e_33.Background = new SolidColorBrush(new ColorW(169, 169, 169, 255));
            // e_34 element
            TextBlock e_34 = new TextBlock();
            e_34.Name = "e_34";
            e_34.Margin = new Thickness(10F, 10F, 10F, 10F);
            e_34.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_34.FontSize = 50F;
            e_34.FontStyle = FontStyle.Bold;
            Binding binding_e_34_Text = new Binding("CoefficientsDisplay");
            e_34.SetBinding(TextBlock.TextProperty, binding_e_34_Text);
            this.e_33.Header = e_34;
            // e_35 element
            this.e_35 = new WrapPanel();
            this.e_33.Content = this.e_35;
            this.e_35.Name = "e_35";
            this.e_35.Orientation = Orientation.Horizontal;
            // e_36 element
            this.e_36 = new Border();
            this.e_35.Children.Add(this.e_36);
            this.e_36.Name = "e_36";
            Style e_36_s = new Style(typeof(Border));
            Setter e_36_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_36_s.Setters.Add(e_36_s_S_0);
            Setter e_36_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_36_s.Setters.Add(e_36_s_S_1);
            Setter e_36_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_36_s.Setters.Add(e_36_s_S_2);
            this.e_36.Style = e_36_s;
            // e_37 element
            this.e_37 = new StackPanel();
            this.e_36.Child = this.e_37;
            this.e_37.Name = "e_37";
            Style e_37_s = new Style(typeof(StackPanel));
            Setter e_37_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_37_s.Setters.Add(e_37_s_S_0);
            Setter e_37_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_37_s.Setters.Add(e_37_s_S_1);
            this.e_37.Style = e_37_s;
            // e_38 element
            this.e_38 = new TextBlock();
            this.e_37.Children.Add(this.e_38);
            this.e_38.Name = "e_38";
            this.e_38.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_38.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_38_Text = new Binding("RestitutionDisplay");
            this.e_38.SetBinding(TextBlock.TextProperty, binding_e_38_Text);
            // Restitution element
            this.Restitution = new TextBox();
            this.e_37.Children.Add(this.Restitution);
            this.Restitution.Name = "Restitution";
            this.Restitution.Tag = "float";
            Binding binding_Restitution_Text = new Binding("ActiveEntity.Restitution");
            binding_Restitution_Text.Mode = BindingMode.TwoWay;
            binding_Restitution_Text.StringFormat = "{0:0.00}";
            this.Restitution.SetBinding(TextBox.TextProperty, binding_Restitution_Text);
            // e_39 element
            this.e_39 = new Border();
            this.e_35.Children.Add(this.e_39);
            this.e_39.Name = "e_39";
            Style e_39_s = new Style(typeof(Border));
            Setter e_39_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_39_s.Setters.Add(e_39_s_S_0);
            Setter e_39_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_39_s.Setters.Add(e_39_s_S_1);
            Setter e_39_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_39_s.Setters.Add(e_39_s_S_2);
            this.e_39.Style = e_39_s;
            // e_40 element
            this.e_40 = new StackPanel();
            this.e_39.Child = this.e_40;
            this.e_40.Name = "e_40";
            Style e_40_s = new Style(typeof(StackPanel));
            Setter e_40_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_40_s.Setters.Add(e_40_s_S_0);
            Setter e_40_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_40_s.Setters.Add(e_40_s_S_1);
            this.e_40.Style = e_40_s;
            // e_41 element
            this.e_41 = new TextBlock();
            this.e_40.Children.Add(this.e_41);
            this.e_41.Name = "e_41";
            this.e_41.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_41.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_41_Text = new Binding("AirResistanceDisplay");
            this.e_41.SetBinding(TextBlock.TextProperty, binding_e_41_Text);
            // AirResistance element
            this.AirResistance = new TextBox();
            this.e_40.Children.Add(this.AirResistance);
            this.AirResistance.Name = "AirResistance";
            this.AirResistance.Tag = "float";
            Binding binding_AirResistance_Text = new Binding("ActiveEntity.AirResistance");
            binding_AirResistance_Text.Mode = BindingMode.TwoWay;
            binding_AirResistance_Text.StringFormat = "{0:0.00}";
            this.AirResistance.SetBinding(TextBox.TextProperty, binding_AirResistance_Text);
            // e_42 element
            this.e_42 = new Border();
            this.e_35.Children.Add(this.e_42);
            this.e_42.Name = "e_42";
            Style e_42_s = new Style(typeof(Border));
            Setter e_42_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_42_s.Setters.Add(e_42_s_S_0);
            Setter e_42_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_42_s.Setters.Add(e_42_s_S_1);
            Setter e_42_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_42_s.Setters.Add(e_42_s_S_2);
            this.e_42.Style = e_42_s;
            // e_43 element
            this.e_43 = new StackPanel();
            this.e_42.Child = this.e_43;
            this.e_43.Name = "e_43";
            Style e_43_s = new Style(typeof(StackPanel));
            Setter e_43_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_43_s.Setters.Add(e_43_s_S_0);
            Setter e_43_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_43_s.Setters.Add(e_43_s_S_1);
            this.e_43.Style = e_43_s;
            // e_44 element
            this.e_44 = new TextBlock();
            this.e_43.Children.Add(this.e_44);
            this.e_44.Name = "e_44";
            this.e_44.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_44.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_44_Text = new Binding("AngularDragDisplay");
            this.e_44.SetBinding(TextBlock.TextProperty, binding_e_44_Text);
            // AngularDrag element
            this.AngularDrag = new TextBox();
            this.e_43.Children.Add(this.AngularDrag);
            this.AngularDrag.Name = "AngularDrag";
            this.AngularDrag.Tag = "float";
            Binding binding_AngularDrag_Text = new Binding("ActiveEntity.AngularDrag");
            binding_AngularDrag_Text.Mode = BindingMode.TwoWay;
            binding_AngularDrag_Text.StringFormat = "{0:0.00}";
            this.AngularDrag.SetBinding(TextBox.TextProperty, binding_AngularDrag_Text);
            // e_45 element
            this.e_45 = new GroupBox();
            this.e_8.Children.Add(this.e_45);
            this.e_45.Name = "e_45";
            Style e_45_s = new Style(typeof(GroupBox));
            Setter e_45_s_S_0 = new Setter(GroupBox.BorderThicknessProperty, new Thickness(5F));
            e_45_s.Setters.Add(e_45_s_S_0);
            Setter e_45_s_S_1 = new Setter(GroupBox.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_45_s.Setters.Add(e_45_s_S_1);
            Setter e_45_s_S_2 = new Setter(GroupBox.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_45_s.Setters.Add(e_45_s_S_2);
            Setter e_45_s_S_3 = new Setter(GroupBox.MarginProperty, new Thickness(10F));
            e_45_s.Setters.Add(e_45_s_S_3);
            this.e_45.Style = e_45_s;
            this.e_45.Background = new SolidColorBrush(new ColorW(169, 169, 169, 255));
            // e_46 element
            TextBlock e_46 = new TextBlock();
            e_46.Name = "e_46";
            e_46.Margin = new Thickness(10F, 10F, 10F, 10F);
            e_46.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_46.FontSize = 50F;
            e_46.FontStyle = FontStyle.Bold;
            Binding binding_e_46_Text = new Binding("WorldDisplay");
            e_46.SetBinding(TextBlock.TextProperty, binding_e_46_Text);
            this.e_45.Header = e_46;
            // e_47 element
            this.e_47 = new WrapPanel();
            this.e_45.Content = this.e_47;
            this.e_47.Name = "e_47";
            this.e_47.Background = new SolidColorBrush(new ColorW(169, 169, 169, 255));
            this.e_47.Orientation = Orientation.Horizontal;
            // e_48 element
            this.e_48 = new Border();
            this.e_47.Children.Add(this.e_48);
            this.e_48.Name = "e_48";
            Style e_48_s = new Style(typeof(Border));
            Setter e_48_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_48_s.Setters.Add(e_48_s_S_0);
            Setter e_48_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_48_s.Setters.Add(e_48_s_S_1);
            Setter e_48_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_48_s.Setters.Add(e_48_s_S_2);
            this.e_48.Style = e_48_s;
            // e_49 element
            this.e_49 = new StackPanel();
            this.e_48.Child = this.e_49;
            this.e_49.Name = "e_49";
            Style e_49_s = new Style(typeof(StackPanel));
            Setter e_49_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_49_s.Setters.Add(e_49_s_S_0);
            Setter e_49_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_49_s.Setters.Add(e_49_s_S_1);
            this.e_49.Style = e_49_s;
            // e_50 element
            this.e_50 = new TextBlock();
            this.e_49.Children.Add(this.e_50);
            this.e_50.Name = "e_50";
            this.e_50.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_50.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_50_Text = new Binding("GravitationalAccelerationDisplay");
            this.e_50.SetBinding(TextBlock.TextProperty, binding_e_50_Text);
            // GravitationalAcceleration element
            this.GravitationalAcceleration = new TextBox();
            this.e_49.Children.Add(this.GravitationalAcceleration);
            this.GravitationalAcceleration.Name = "GravitationalAcceleration";
            this.GravitationalAcceleration.Tag = "float";
            Binding binding_GravitationalAcceleration_Text = new Binding("ActiveEntity.GravitationalAcceleration");
            binding_GravitationalAcceleration_Text.Mode = BindingMode.TwoWay;
            binding_GravitationalAcceleration_Text.StringFormat = "{0:0.00}";
            this.GravitationalAcceleration.SetBinding(TextBox.TextProperty, binding_GravitationalAcceleration_Text);
            // e_51 element
            this.e_51 = new Grid();
            this.e_0.Children.Add(this.e_51);
            this.e_51.Name = "e_51";
            this.e_51.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_51.Background = new SolidColorBrush(new ColorW(169, 169, 169, 255));
            ColumnDefinition col_e_51_0 = new ColumnDefinition();
            col_e_51_0.Width = new GridLength(1F, GridUnitType.Auto);
            this.e_51.ColumnDefinitions.Add(col_e_51_0);
            ColumnDefinition col_e_51_1 = new ColumnDefinition();
            col_e_51_1.Width = new GridLength(0.09F, GridUnitType.Star);
            this.e_51.ColumnDefinitions.Add(col_e_51_1);
            ColumnDefinition col_e_51_2 = new ColumnDefinition();
            col_e_51_2.Width = new GridLength(0.09F, GridUnitType.Star);
            this.e_51.ColumnDefinitions.Add(col_e_51_2);
            ColumnDefinition col_e_51_3 = new ColumnDefinition();
            col_e_51_3.Width = new GridLength(0.15F, GridUnitType.Star);
            this.e_51.ColumnDefinitions.Add(col_e_51_3);
            ColumnDefinition col_e_51_4 = new ColumnDefinition();
            col_e_51_4.Width = new GridLength(0.5F, GridUnitType.Star);
            this.e_51.ColumnDefinitions.Add(col_e_51_4);
            ColumnDefinition col_e_51_5 = new ColumnDefinition();
            col_e_51_5.Width = new GridLength(0.1F, GridUnitType.Star);
            this.e_51.ColumnDefinitions.Add(col_e_51_5);
            Grid.SetRow(this.e_51, 3);
            // e_52 element
            this.e_52 = new StackPanel();
            this.e_51.Children.Add(this.e_52);
            this.e_52.Name = "e_52";
            this.e_52.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_52.Orientation = Orientation.Horizontal;
            Grid.SetColumn(this.e_52, 0);
            // color element
            this.color = new ListBox();
            this.e_52.Children.Add(this.color);
            this.color.Name = "color";
            Func<UIElement, UIElement> color_dtFunc = color_dtMethod;
            this.color.ItemTemplate = new DataTemplate(color_dtFunc);
            this.color.SelectedIndex = -1;
            Binding binding_color_ItemsSource = new Binding("AvailableBrushes");
            this.color.SetBinding(ListBox.ItemsSourceProperty, binding_color_ItemsSource);
            // e_55 element
            this.e_55 = new Grid();
            this.e_51.Children.Add(this.e_55);
            this.e_55.Name = "e_55";
            RowDefinition row_e_55_0 = new RowDefinition();
            row_e_55_0.Height = new GridLength(0.1F, GridUnitType.Star);
            this.e_55.RowDefinitions.Add(row_e_55_0);
            RowDefinition row_e_55_1 = new RowDefinition();
            row_e_55_1.Height = new GridLength(0.8F, GridUnitType.Star);
            this.e_55.RowDefinitions.Add(row_e_55_1);
            RowDefinition row_e_55_2 = new RowDefinition();
            row_e_55_2.Height = new GridLength(0.1F, GridUnitType.Star);
            this.e_55.RowDefinitions.Add(row_e_55_2);
            Grid.SetColumn(this.e_55, 1);
            // e_56 element
            this.e_56 = new Rectangle();
            this.e_55.Children.Add(this.e_56);
            this.e_56.Name = "e_56";
            Grid.SetRow(this.e_56, 0);
            // preview element
            this.preview = new Rectangle();
            this.e_55.Children.Add(this.preview);
            this.preview.Name = "preview";
            this.preview.Width = 100F;
            this.preview.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.preview.VerticalAlignment = VerticalAlignment.Stretch;
            this.preview.Stretch = Stretch.UniformToFill;
            Grid.SetRow(this.preview, 1);
            // e_57 element
            this.e_57 = new Rectangle();
            this.e_55.Children.Add(this.e_57);
            this.e_57.Name = "e_57";
            Grid.SetRow(this.e_57, 2);
            // add element
            this.add = new Button();
            this.e_51.Children.Add(this.add);
            this.add.Name = "add";
            Grid.SetColumn(this.add, 2);
            // e_58 element
            this.e_58 = new TextBlock();
            this.add.Content = this.e_58;
            this.e_58.Name = "e_58";
            this.e_58.FontSize = 30F;
            Binding binding_e_58_Text = new Binding("ButtonAddDisplay");
            this.e_58.SetBinding(TextBlock.TextProperty, binding_e_58_Text);
            // e_59 element
            this.e_59 = new WrapPanel();
            this.e_51.Children.Add(this.e_59);
            this.e_59.Name = "e_59";
            this.e_59.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_59.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(this.e_59, 3);
            // e_60 element
            this.e_60 = new TextBlock();
            this.e_59.Children.Add(this.e_60);
            this.e_60.Name = "e_60";
            this.e_60.VerticalAlignment = VerticalAlignment.Center;
            this.e_60.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_60.FontSize = 20F;
            Binding binding_e_60_Text = new Binding("CheckboxEnableCollisionsDisplay");
            this.e_60.SetBinding(TextBlock.TextProperty, binding_e_60_Text);
            // e_61 element
            this.e_61 = new CheckBox();
            this.e_59.Children.Add(this.e_61);
            this.e_61.Name = "e_61";
            this.e_61.Margin = new Thickness(5F, 0F, 0F, 0F);
            this.e_61.VerticalAlignment = VerticalAlignment.Center;
            Binding binding_e_61_IsChecked = new Binding("EnableCollision");
            this.e_61.SetBinding(CheckBox.IsCheckedProperty, binding_e_61_IsChecked);
            // e_62 element
            this.e_62 = new WrapPanel();
            this.e_51.Children.Add(this.e_62);
            this.e_62.Name = "e_62";
            this.e_62.VerticalAlignment = VerticalAlignment.Center;
            this.e_62.Orientation = Orientation.Vertical;
            Grid.SetColumn(this.e_62, 4);
            // e_63 element
            this.e_63 = new WrapPanel();
            this.e_62.Children.Add(this.e_63);
            this.e_63.Name = "e_63";
            this.e_63.Background = new SolidColorBrush(new ColorW(169, 169, 169, 255));
            this.e_63.Orientation = Orientation.Horizontal;
            // e_64 element
            this.e_64 = new Border();
            this.e_63.Children.Add(this.e_64);
            this.e_64.Name = "e_64";
            this.e_64.Height = 99F;
            Style e_64_s = new Style(typeof(Border));
            Setter e_64_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_64_s.Setters.Add(e_64_s_S_0);
            Setter e_64_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_64_s.Setters.Add(e_64_s_S_1);
            Setter e_64_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_64_s.Setters.Add(e_64_s_S_2);
            this.e_64.Style = e_64_s;
            // e_65 element
            this.e_65 = new StackPanel();
            this.e_64.Child = this.e_65;
            this.e_65.Name = "e_65";
            Style e_65_s = new Style(typeof(StackPanel));
            Setter e_65_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            e_65_s.Setters.Add(e_65_s_S_0);
            Setter e_65_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            e_65_s.Setters.Add(e_65_s_S_1);
            this.e_65.Style = e_65_s;
            // e_66 element
            this.e_66 = new TextBlock();
            this.e_65.Children.Add(this.e_66);
            this.e_66.Name = "e_66";
            this.e_66.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_66.VerticalAlignment = VerticalAlignment.Center;
            this.e_66.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_66.FontSize = 30F;
            Binding binding_e_66_Text = new Binding("UnitRatioDisplay");
            this.e_66.SetBinding(TextBlock.TextProperty, binding_e_66_Text);
            // UnitRatio element
            this.UnitRatio = new TextBox();
            this.e_65.Children.Add(this.UnitRatio);
            this.UnitRatio.Name = "UnitRatio";
            this.UnitRatio.Height = 93F;
            this.UnitRatio.Tag = "float";
            this.UnitRatio.VerticalAlignment = VerticalAlignment.Center;
            this.UnitRatio.FontSize = 30F;
            Binding binding_UnitRatio_Text = new Binding("UnitRatio");
            binding_UnitRatio_Text.Mode = BindingMode.TwoWay;
            binding_UnitRatio_Text.StringFormat = "{0:0.00}";
            this.UnitRatio.SetBinding(TextBox.TextProperty, binding_UnitRatio_Text);
            // e_67 element
            this.e_67 = new Button();
            this.e_51.Children.Add(this.e_67);
            this.e_67.Name = "e_67";
            this.e_67.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_67.CommandParameter = null;
            Grid.SetColumn(this.e_67, 5);
            Binding binding_e_67_Command = new Binding("StartSimulation");
            this.e_67.SetBinding(Button.CommandProperty, binding_e_67_Command);
            // e_68 element
            this.e_68 = new TextBlock();
            this.e_67.Content = this.e_68;
            this.e_68.Name = "e_68";
            this.e_68.Text = "Start";
            this.e_68.FontSize = 30F;
            FontManager.Instance.AddFont("Segoe UI", 30F, FontStyle.Regular, "Segoe_UI_22.5_Regular");
            FontManager.Instance.AddFont("Segoe UI", 50F, FontStyle.Bold, "Segoe_UI_37.5_Bold");
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Regular, "Segoe_UI_15_Regular");
        }
        
        private static void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
        
        private static UIElement tabItems_iptMethod(UIElement parent) {
            // e_1 element
            UniformGrid e_1 = new UniformGrid();
            e_1.Parent = parent;
            e_1.Name = "e_1";
            e_1.IsItemsHost = true;
            e_1.Rows = 1;
            return e_1;
        }
        
        private static UIElement e_2_s_S_3_ctMethod(UIElement parent) {
            // e_3 element
            Grid e_3 = new Grid();
            e_3.Parent = parent;
            e_3.Name = "e_3";
            Binding binding_e_3_Background = new Binding("Background");
            binding_e_3_Background.Source = parent;
            e_3.SetBinding(Grid.BackgroundProperty, binding_e_3_Background);
            // e_4 element
            Border e_4 = new Border();
            e_3.Children.Add(e_4);
            e_4.Name = "e_4";
            Binding binding_e_4_BorderThickness = new Binding("BorderThickness");
            binding_e_4_BorderThickness.Source = parent;
            e_4.SetBinding(Border.BorderThicknessProperty, binding_e_4_BorderThickness);
            Binding binding_e_4_BorderBrush = new Binding("BorderBrush");
            binding_e_4_BorderBrush.Source = parent;
            e_4.SetBinding(Border.BorderBrushProperty, binding_e_4_BorderBrush);
            return e_3;
        }
        
        private static UIElement tabItems_dtMethod(UIElement parent) {
            // e_2 element
            Button e_2 = new Button();
            e_2.Parent = parent;
            e_2.Name = "e_2";
            Style e_2_s = new Style(typeof(Button));
            Setter e_2_s_S_0 = new Setter(Button.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_2_s.Setters.Add(e_2_s_S_0);
            Setter e_2_s_S_1 = new Setter(Button.BorderThicknessProperty, new Thickness(3F));
            e_2_s.Setters.Add(e_2_s_S_1);
            Setter e_2_s_S_2 = new Setter(Button.MarginProperty, new Thickness(6F));
            e_2_s.Setters.Add(e_2_s_S_2);
            Func<UIElement, UIElement> e_2_s_S_3_ctFunc = e_2_s_S_3_ctMethod;
            ControlTemplate e_2_s_S_3_ct = new ControlTemplate(typeof(Button), e_2_s_S_3_ctFunc);
            Setter e_2_s_S_3 = new Setter(Button.TemplateProperty, e_2_s_S_3_ct);
            e_2_s.Setters.Add(e_2_s_S_3);
            Trigger e_2_s_T_0 = new Trigger();
            e_2_s_T_0.Property = Button.IsEnabledProperty;
            e_2_s_T_0.Value = true;
            Setter e_2_s_T_0_S_0 = new Setter(Button.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_2_s_T_0.Setters.Add(e_2_s_T_0_S_0);
            e_2_s.Triggers.Add(e_2_s_T_0);
            Trigger e_2_s_T_1 = new Trigger();
            e_2_s_T_1.Property = Button.IsEnabledProperty;
            e_2_s_T_1.Value = false;
            Setter e_2_s_T_1_S_0 = new Setter(Button.BorderBrushProperty, new SolidColorBrush(new ColorW(100, 149, 237, 255)));
            e_2_s_T_1.Setters.Add(e_2_s_T_1_S_0);
            e_2_s.Triggers.Add(e_2_s_T_1);
            EventTrigger e_2_s_ET_2 = new EventTrigger(Button.MouseEnterEvent);
            e_2_s.Triggers.Add(e_2_s_ET_2);
            BeginStoryboard e_2_s_ET_2_AC_0 = new BeginStoryboard();
            e_2_s_ET_2_AC_0.Name = "e_2_s_ET_2_AC_0";
            e_2_s_ET_2.AddAction(e_2_s_ET_2_AC_0);
            Storyboard e_2_s_ET_2_AC_0_SB = new Storyboard();
            e_2_s_ET_2_AC_0.Storyboard = e_2_s_ET_2_AC_0_SB;
            e_2_s_ET_2_AC_0_SB.Name = "e_2_s_ET_2_AC_0_SB";
            ThicknessAnimation e_2_s_ET_2_AC_0_SB_TL_0 = new ThicknessAnimation();
            e_2_s_ET_2_AC_0_SB_TL_0.Name = "e_2_s_ET_2_AC_0_SB_TL_0";
            e_2_s_ET_2_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            e_2_s_ET_2_AC_0_SB_TL_0.From = new Thickness(3F, 3F, 3F, 3F);
            e_2_s_ET_2_AC_0_SB_TL_0.To = new Thickness(6F, 6F, 6F, 6F);
            SineEase e_2_s_ET_2_AC_0_SB_TL_0_EA = new SineEase();
            e_2_s_ET_2_AC_0_SB_TL_0.EasingFunction = e_2_s_ET_2_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(e_2_s_ET_2_AC_0_SB_TL_0, Button.BorderThicknessProperty);
            e_2_s_ET_2_AC_0_SB.Children.Add(e_2_s_ET_2_AC_0_SB_TL_0);
            EventTrigger e_2_s_ET_3 = new EventTrigger(Button.MouseLeaveEvent);
            e_2_s.Triggers.Add(e_2_s_ET_3);
            BeginStoryboard e_2_s_ET_3_AC_0 = new BeginStoryboard();
            e_2_s_ET_3_AC_0.Name = "e_2_s_ET_3_AC_0";
            e_2_s_ET_3.AddAction(e_2_s_ET_3_AC_0);
            Storyboard e_2_s_ET_3_AC_0_SB = new Storyboard();
            e_2_s_ET_3_AC_0.Storyboard = e_2_s_ET_3_AC_0_SB;
            e_2_s_ET_3_AC_0_SB.Name = "e_2_s_ET_3_AC_0_SB";
            ThicknessAnimation e_2_s_ET_3_AC_0_SB_TL_0 = new ThicknessAnimation();
            e_2_s_ET_3_AC_0_SB_TL_0.Name = "e_2_s_ET_3_AC_0_SB_TL_0";
            e_2_s_ET_3_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            e_2_s_ET_3_AC_0_SB_TL_0.From = new Thickness(6F, 6F, 6F, 6F);
            e_2_s_ET_3_AC_0_SB_TL_0.To = new Thickness(3F, 3F, 3F, 3F);
            SineEase e_2_s_ET_3_AC_0_SB_TL_0_EA = new SineEase();
            e_2_s_ET_3_AC_0_SB_TL_0.EasingFunction = e_2_s_ET_3_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(e_2_s_ET_3_AC_0_SB_TL_0, Button.BorderThicknessProperty);
            e_2_s_ET_3_AC_0_SB.Children.Add(e_2_s_ET_3_AC_0_SB_TL_0);
            e_2.Style = e_2_s;
            e_2.CommandParameter = null;
            Binding binding_e_2_IsEnabled = new Binding("IsSelectable");
            e_2.SetBinding(Button.IsEnabledProperty, binding_e_2_IsEnabled);
            Binding binding_e_2_Background = new Binding("ColorBrush");
            e_2.SetBinding(Button.BackgroundProperty, binding_e_2_Background);
            Binding binding_e_2_Command = new Binding("TabClickDown");
            e_2.SetBinding(Button.CommandProperty, binding_e_2_Command);
            return e_2;
        }
        
        private static UIElement color_dtMethod(UIElement parent) {
            // e_53 element
            Border e_53 = new Border();
            e_53.Parent = parent;
            e_53.Name = "e_53";
            e_53.BorderBrush = new SolidColorBrush(new ColorW(240, 248, 255, 255));
            e_53.BorderThickness = new Thickness(2F, 2F, 2F, 2F);
            // e_54 element
            Grid e_54 = new Grid();
            e_53.Child = e_54;
            e_54.Name = "e_54";
            e_54.Height = 25F;
            e_54.Width = 100F;
            e_54.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_54.VerticalAlignment = VerticalAlignment.Stretch;
            Binding binding_e_54_Background = new Binding();
            e_54.SetBinding(Grid.BackgroundProperty, binding_e_54_Background);
            return e_53;
        }
    }
}

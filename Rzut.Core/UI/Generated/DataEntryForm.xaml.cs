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
        
        private ScrollViewer entityEditor;
        
        private WrapPanel e_7;
        
        private Border e_8;
        
        private StackPanel e_9;
        
        private TextBlock e_10;
        
        private TextBox Radius;
        
        private Border e_11;
        
        private StackPanel e_12;
        
        private TextBlock e_13;
        
        private TextBox Mass;
        
        private Border e_14;
        
        private StackPanel e_15;
        
        private TextBlock e_16;
        
        private TextBox StartY;
        
        private Border e_17;
        
        private StackPanel e_18;
        
        private TextBlock e_19;
        
        private TextBox StartX;
        
        private Border e_20;
        
        private StackPanel e_21;
        
        private TextBlock e_22;
        
        private TextBox StartAngle;
        
        private Border e_23;
        
        private StackPanel e_24;
        
        private TextBlock e_25;
        
        private TextBox Velocity;
        
        private Border e_26;
        
        private StackPanel e_27;
        
        private TextBlock e_28;
        
        private TextBox Friction;
        
        private Border e_29;
        
        private StackPanel e_30;
        
        private TextBlock e_31;
        
        private TextBox AirResistance;
        
        private Border e_32;
        
        private StackPanel e_33;
        
        private TextBlock e_34;
        
        private TextBox AngularDrag;
        
        private Grid e_35;
        
        private Button e_36;
        
        private TextBlock e_37;
        
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
            row_e_0_2.Height = new GridLength(0.74F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_2);
            RowDefinition row_e_0_3 = new RowDefinition();
            row_e_0_3.Height = new GridLength(0.08F, GridUnitType.Star);
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
            // errors element
            this.errors = new TextBlock();
            this.e_6.Children.Add(this.errors);
            this.errors.Name = "errors";
            this.errors.HorizontalAlignment = HorizontalAlignment.Center;
            this.errors.VerticalAlignment = VerticalAlignment.Center;
            this.errors.Foreground = new SolidColorBrush(new ColorW(255, 0, 0, 255));
            this.errors.TextAlignment = TextAlignment.Center;
            // entityEditor element
            this.entityEditor = new ScrollViewer();
            this.e_0.Children.Add(this.entityEditor);
            this.entityEditor.Name = "entityEditor";
            Grid.SetRow(this.entityEditor, 2);
            // e_7 element
            this.e_7 = new WrapPanel();
            this.entityEditor.Content = this.e_7;
            this.e_7.Name = "e_7";
            this.e_7.Orientation = Orientation.Horizontal;
            // e_8 element
            this.e_8 = new Border();
            this.e_7.Children.Add(this.e_8);
            this.e_8.Name = "e_8";
            Style e_8_s = new Style(typeof(Border));
            Setter e_8_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_8_s.Setters.Add(e_8_s_S_0);
            Setter e_8_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_8_s.Setters.Add(e_8_s_S_1);
            Setter e_8_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_8_s.Setters.Add(e_8_s_S_2);
            this.e_8.Style = e_8_s;
            // e_9 element
            this.e_9 = new StackPanel();
            this.e_8.Child = this.e_9;
            this.e_9.Name = "e_9";
            this.e_9.Orientation = Orientation.Horizontal;
            // e_10 element
            this.e_10 = new TextBlock();
            this.e_9.Children.Add(this.e_10);
            this.e_10.Name = "e_10";
            this.e_10.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_10.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_10_Text = new Binding("RadiusDisplay");
            this.e_10.SetBinding(TextBlock.TextProperty, binding_e_10_Text);
            // Radius element
            this.Radius = new TextBox();
            this.e_9.Children.Add(this.Radius);
            this.Radius.Name = "Radius";
            this.Radius.Tag = "float";
            Binding binding_Radius_Text = new Binding("ActiveEntity.Radius");
            binding_Radius_Text.Mode = BindingMode.TwoWay;
            binding_Radius_Text.StringFormat = "{0:0.00}";
            this.Radius.SetBinding(TextBox.TextProperty, binding_Radius_Text);
            // e_11 element
            this.e_11 = new Border();
            this.e_7.Children.Add(this.e_11);
            this.e_11.Name = "e_11";
            Style e_11_s = new Style(typeof(Border));
            Setter e_11_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_11_s.Setters.Add(e_11_s_S_0);
            Setter e_11_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_11_s.Setters.Add(e_11_s_S_1);
            Setter e_11_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_11_s.Setters.Add(e_11_s_S_2);
            this.e_11.Style = e_11_s;
            // e_12 element
            this.e_12 = new StackPanel();
            this.e_11.Child = this.e_12;
            this.e_12.Name = "e_12";
            this.e_12.Orientation = Orientation.Horizontal;
            // e_13 element
            this.e_13 = new TextBlock();
            this.e_12.Children.Add(this.e_13);
            this.e_13.Name = "e_13";
            this.e_13.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_13.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_13_Text = new Binding("MassDisplay");
            this.e_13.SetBinding(TextBlock.TextProperty, binding_e_13_Text);
            // Mass element
            this.Mass = new TextBox();
            this.e_12.Children.Add(this.Mass);
            this.Mass.Name = "Mass";
            this.Mass.Tag = "float";
            Binding binding_Mass_Text = new Binding("ActiveEntity.Mass");
            binding_Mass_Text.Mode = BindingMode.TwoWay;
            binding_Mass_Text.StringFormat = "{0:0.00}";
            this.Mass.SetBinding(TextBox.TextProperty, binding_Mass_Text);
            // e_14 element
            this.e_14 = new Border();
            this.e_7.Children.Add(this.e_14);
            this.e_14.Name = "e_14";
            Style e_14_s = new Style(typeof(Border));
            Setter e_14_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_14_s.Setters.Add(e_14_s_S_0);
            Setter e_14_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_14_s.Setters.Add(e_14_s_S_1);
            Setter e_14_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_14_s.Setters.Add(e_14_s_S_2);
            this.e_14.Style = e_14_s;
            // e_15 element
            this.e_15 = new StackPanel();
            this.e_14.Child = this.e_15;
            this.e_15.Name = "e_15";
            this.e_15.Orientation = Orientation.Horizontal;
            // e_16 element
            this.e_16 = new TextBlock();
            this.e_15.Children.Add(this.e_16);
            this.e_16.Name = "e_16";
            this.e_16.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_16.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_16_Text = new Binding("StartYDisplay");
            this.e_16.SetBinding(TextBlock.TextProperty, binding_e_16_Text);
            // StartY element
            this.StartY = new TextBox();
            this.e_15.Children.Add(this.StartY);
            this.StartY.Name = "StartY";
            this.StartY.Tag = "float";
            Binding binding_StartY_Text = new Binding("ActiveEntity.StartY");
            binding_StartY_Text.Mode = BindingMode.TwoWay;
            binding_StartY_Text.StringFormat = "{0:0.00}";
            this.StartY.SetBinding(TextBox.TextProperty, binding_StartY_Text);
            // e_17 element
            this.e_17 = new Border();
            this.e_7.Children.Add(this.e_17);
            this.e_17.Name = "e_17";
            Style e_17_s = new Style(typeof(Border));
            Setter e_17_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_17_s.Setters.Add(e_17_s_S_0);
            Setter e_17_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_17_s.Setters.Add(e_17_s_S_1);
            Setter e_17_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_17_s.Setters.Add(e_17_s_S_2);
            this.e_17.Style = e_17_s;
            // e_18 element
            this.e_18 = new StackPanel();
            this.e_17.Child = this.e_18;
            this.e_18.Name = "e_18";
            this.e_18.Orientation = Orientation.Horizontal;
            // e_19 element
            this.e_19 = new TextBlock();
            this.e_18.Children.Add(this.e_19);
            this.e_19.Name = "e_19";
            this.e_19.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_19.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_19_Text = new Binding("StartXDisplay");
            this.e_19.SetBinding(TextBlock.TextProperty, binding_e_19_Text);
            // StartX element
            this.StartX = new TextBox();
            this.e_18.Children.Add(this.StartX);
            this.StartX.Name = "StartX";
            this.StartX.Tag = "float";
            Binding binding_StartX_Text = new Binding("ActiveEntity.StartX");
            binding_StartX_Text.Mode = BindingMode.TwoWay;
            binding_StartX_Text.StringFormat = "{0:0.00}";
            this.StartX.SetBinding(TextBox.TextProperty, binding_StartX_Text);
            // e_20 element
            this.e_20 = new Border();
            this.e_7.Children.Add(this.e_20);
            this.e_20.Name = "e_20";
            Style e_20_s = new Style(typeof(Border));
            Setter e_20_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_20_s.Setters.Add(e_20_s_S_0);
            Setter e_20_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_20_s.Setters.Add(e_20_s_S_1);
            Setter e_20_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_20_s.Setters.Add(e_20_s_S_2);
            this.e_20.Style = e_20_s;
            // e_21 element
            this.e_21 = new StackPanel();
            this.e_20.Child = this.e_21;
            this.e_21.Name = "e_21";
            this.e_21.Orientation = Orientation.Horizontal;
            // e_22 element
            this.e_22 = new TextBlock();
            this.e_21.Children.Add(this.e_22);
            this.e_22.Name = "e_22";
            this.e_22.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_22.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_22_Text = new Binding("StartAngleDisplay");
            this.e_22.SetBinding(TextBlock.TextProperty, binding_e_22_Text);
            // StartAngle element
            this.StartAngle = new TextBox();
            this.e_21.Children.Add(this.StartAngle);
            this.StartAngle.Name = "StartAngle";
            this.StartAngle.Tag = "float";
            Binding binding_StartAngle_Text = new Binding("ActiveEntity.StartAngle");
            binding_StartAngle_Text.Mode = BindingMode.TwoWay;
            binding_StartAngle_Text.StringFormat = "{0:0}";
            this.StartAngle.SetBinding(TextBox.TextProperty, binding_StartAngle_Text);
            // e_23 element
            this.e_23 = new Border();
            this.e_7.Children.Add(this.e_23);
            this.e_23.Name = "e_23";
            Style e_23_s = new Style(typeof(Border));
            Setter e_23_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_23_s.Setters.Add(e_23_s_S_0);
            Setter e_23_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_23_s.Setters.Add(e_23_s_S_1);
            Setter e_23_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_23_s.Setters.Add(e_23_s_S_2);
            this.e_23.Style = e_23_s;
            // e_24 element
            this.e_24 = new StackPanel();
            this.e_23.Child = this.e_24;
            this.e_24.Name = "e_24";
            this.e_24.Orientation = Orientation.Horizontal;
            // e_25 element
            this.e_25 = new TextBlock();
            this.e_24.Children.Add(this.e_25);
            this.e_25.Name = "e_25";
            this.e_25.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_25.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_25_Text = new Binding("VelocityDisplay");
            this.e_25.SetBinding(TextBlock.TextProperty, binding_e_25_Text);
            // Velocity element
            this.Velocity = new TextBox();
            this.e_24.Children.Add(this.Velocity);
            this.Velocity.Name = "Velocity";
            this.Velocity.Tag = "float";
            Binding binding_Velocity_Text = new Binding("ActiveEntity.Velocity");
            binding_Velocity_Text.Mode = BindingMode.TwoWay;
            binding_Velocity_Text.StringFormat = "{0:0.00}";
            this.Velocity.SetBinding(TextBox.TextProperty, binding_Velocity_Text);
            // e_26 element
            this.e_26 = new Border();
            this.e_7.Children.Add(this.e_26);
            this.e_26.Name = "e_26";
            Style e_26_s = new Style(typeof(Border));
            Setter e_26_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_26_s.Setters.Add(e_26_s_S_0);
            Setter e_26_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_26_s.Setters.Add(e_26_s_S_1);
            Setter e_26_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_26_s.Setters.Add(e_26_s_S_2);
            this.e_26.Style = e_26_s;
            // e_27 element
            this.e_27 = new StackPanel();
            this.e_26.Child = this.e_27;
            this.e_27.Name = "e_27";
            this.e_27.Orientation = Orientation.Horizontal;
            // e_28 element
            this.e_28 = new TextBlock();
            this.e_27.Children.Add(this.e_28);
            this.e_28.Name = "e_28";
            this.e_28.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_28.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_28_Text = new Binding("FrictionDisplay");
            this.e_28.SetBinding(TextBlock.TextProperty, binding_e_28_Text);
            // Friction element
            this.Friction = new TextBox();
            this.e_27.Children.Add(this.Friction);
            this.Friction.Name = "Friction";
            this.Friction.Tag = "float";
            Binding binding_Friction_Text = new Binding("ActiveEntity.Friction");
            binding_Friction_Text.Mode = BindingMode.TwoWay;
            binding_Friction_Text.StringFormat = "{0:0.00}";
            this.Friction.SetBinding(TextBox.TextProperty, binding_Friction_Text);
            // e_29 element
            this.e_29 = new Border();
            this.e_7.Children.Add(this.e_29);
            this.e_29.Name = "e_29";
            Style e_29_s = new Style(typeof(Border));
            Setter e_29_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_29_s.Setters.Add(e_29_s_S_0);
            Setter e_29_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_29_s.Setters.Add(e_29_s_S_1);
            Setter e_29_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_29_s.Setters.Add(e_29_s_S_2);
            this.e_29.Style = e_29_s;
            // e_30 element
            this.e_30 = new StackPanel();
            this.e_29.Child = this.e_30;
            this.e_30.Name = "e_30";
            this.e_30.Orientation = Orientation.Horizontal;
            // e_31 element
            this.e_31 = new TextBlock();
            this.e_30.Children.Add(this.e_31);
            this.e_31.Name = "e_31";
            this.e_31.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_31.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_31_Text = new Binding("AirResistanceDisplay");
            this.e_31.SetBinding(TextBlock.TextProperty, binding_e_31_Text);
            // AirResistance element
            this.AirResistance = new TextBox();
            this.e_30.Children.Add(this.AirResistance);
            this.AirResistance.Name = "AirResistance";
            this.AirResistance.Tag = "float";
            Binding binding_AirResistance_Text = new Binding("ActiveEntity.AirResistance");
            binding_AirResistance_Text.Mode = BindingMode.TwoWay;
            binding_AirResistance_Text.StringFormat = "{0:0.00}";
            this.AirResistance.SetBinding(TextBox.TextProperty, binding_AirResistance_Text);
            // e_32 element
            this.e_32 = new Border();
            this.e_7.Children.Add(this.e_32);
            this.e_32.Name = "e_32";
            Style e_32_s = new Style(typeof(Border));
            Setter e_32_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            e_32_s.Setters.Add(e_32_s_S_0);
            Setter e_32_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            e_32_s.Setters.Add(e_32_s_S_1);
            Setter e_32_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            e_32_s.Setters.Add(e_32_s_S_2);
            this.e_32.Style = e_32_s;
            // e_33 element
            this.e_33 = new StackPanel();
            this.e_32.Child = this.e_33;
            this.e_33.Name = "e_33";
            this.e_33.Orientation = Orientation.Horizontal;
            // e_34 element
            this.e_34 = new TextBlock();
            this.e_33.Children.Add(this.e_34);
            this.e_34.Name = "e_34";
            this.e_34.Margin = new Thickness(10F, 10F, 10F, 10F);
            this.e_34.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            Binding binding_e_34_Text = new Binding("AngularDragDisplay");
            this.e_34.SetBinding(TextBlock.TextProperty, binding_e_34_Text);
            // AngularDrag element
            this.AngularDrag = new TextBox();
            this.e_33.Children.Add(this.AngularDrag);
            this.AngularDrag.Name = "AngularDrag";
            this.AngularDrag.Tag = "float";
            Binding binding_AngularDrag_Text = new Binding("ActiveEntity.AngularDrag");
            binding_AngularDrag_Text.Mode = BindingMode.TwoWay;
            binding_AngularDrag_Text.StringFormat = "{0:0.00}";
            this.AngularDrag.SetBinding(TextBox.TextProperty, binding_AngularDrag_Text);
            // e_35 element
            this.e_35 = new Grid();
            this.e_0.Children.Add(this.e_35);
            this.e_35.Name = "e_35";
            Grid.SetRow(this.e_35, 3);
            // e_36 element
            this.e_36 = new Button();
            this.e_35.Children.Add(this.e_36);
            this.e_36.Name = "e_36";
            this.e_36.CommandParameter = null;
            Binding binding_e_36_Command = new Binding("StartSimulation");
            this.e_36.SetBinding(Button.CommandProperty, binding_e_36_Command);
            // e_37 element
            this.e_37 = new TextBlock();
            this.e_36.Content = this.e_37;
            this.e_37.Name = "e_37";
            this.e_37.Text = "start this shit";
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
    }
}

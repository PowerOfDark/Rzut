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
    public partial class LanguageSelection : UIRoot {
        
        private Grid e_0;
        
        private TextBlock e_1;
        
        private TextBlock e_2;
        
        private Rectangle pl;
        
        private Rectangle en;
        
        private Rectangle de;
        
        private Button apply;
        
        private TextBlock e_3;
        
        public LanguageSelection() : 
                base() {
            this.Initialize();
        }
        
        public LanguageSelection(int width, int height) : 
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
            this.Background = new SolidColorBrush(new ColorW(240, 248, 255, 255));
            InitializeElementResources(this);
            // e_0 element
            this.e_0 = new Grid();
            this.Content = this.e_0;
            this.e_0.Name = "e_0";
            RowDefinition row_e_0_0 = new RowDefinition();
            row_e_0_0.Height = new GridLength(1F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_0);
            RowDefinition row_e_0_1 = new RowDefinition();
            row_e_0_1.Height = new GridLength(0.6F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_1);
            RowDefinition row_e_0_2 = new RowDefinition();
            row_e_0_2.Height = new GridLength(0.8F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_2);
            RowDefinition row_e_0_3 = new RowDefinition();
            row_e_0_3.Height = new GridLength(2F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_3);
            ColumnDefinition col_e_0_0 = new ColumnDefinition();
            col_e_0_0.Width = new GridLength(1F, GridUnitType.Star);
            this.e_0.ColumnDefinitions.Add(col_e_0_0);
            ColumnDefinition col_e_0_1 = new ColumnDefinition();
            col_e_0_1.Width = new GridLength(1F, GridUnitType.Star);
            this.e_0.ColumnDefinitions.Add(col_e_0_1);
            ColumnDefinition col_e_0_2 = new ColumnDefinition();
            col_e_0_2.Width = new GridLength(1F, GridUnitType.Star);
            this.e_0.ColumnDefinitions.Add(col_e_0_2);
            ColumnDefinition col_e_0_3 = new ColumnDefinition();
            col_e_0_3.Width = new GridLength(1F, GridUnitType.Auto);
            this.e_0.ColumnDefinitions.Add(col_e_0_3);
            // e_1 element
            this.e_1 = new TextBlock();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_1.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_1.Foreground = new SolidColorBrush(new ColorW(189, 183, 107, 255));
            this.e_1.FontSize = 80F;
            Grid.SetRow(this.e_1, 0);
            Grid.SetColumnSpan(this.e_1, 3);
            Binding binding_e_1_Text = new Binding("Title");
            this.e_1.SetBinding(TextBlock.TextProperty, binding_e_1_Text);
            // e_2 element
            this.e_2 = new TextBlock();
            this.e_0.Children.Add(this.e_2);
            this.e_2.Name = "e_2";
            this.e_2.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_2.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_2.Foreground = new SolidColorBrush(new ColorW(189, 183, 107, 255));
            this.e_2.FontSize = 50F;
            Grid.SetRow(this.e_2, 1);
            Grid.SetColumnSpan(this.e_2, 3);
            Binding binding_e_2_Text = new Binding("Action");
            binding_e_2_Text.FallbackValue = "ChooseLanguage";
            this.e_2.SetBinding(TextBlock.TextProperty, binding_e_2_Text);
            // pl element
            this.pl = new Rectangle();
            this.e_0.Children.Add(this.pl);
            this.pl.Name = "pl";
            Style pl_s = new Style(typeof(Rectangle));
            Setter pl_s_S_0 = new Setter(Rectangle.SnapsToDevicePixelsProperty, false);
            pl_s.Setters.Add(pl_s_S_0);
            Setter pl_s_S_1 = new Setter(Rectangle.HorizontalAlignmentProperty, HorizontalAlignment.Stretch);
            pl_s.Setters.Add(pl_s_S_1);
            Setter pl_s_S_2 = new Setter(Rectangle.VerticalAlignmentProperty, VerticalAlignment.Stretch);
            pl_s.Setters.Add(pl_s_S_2);
            Setter pl_s_S_3 = new Setter(Rectangle.RadiusXProperty, 10F);
            pl_s.Setters.Add(pl_s_S_3);
            Setter pl_s_S_4 = new Setter(Rectangle.RadiusYProperty, 10F);
            pl_s.Setters.Add(pl_s_S_4);
            Setter pl_s_S_5 = new Setter(Rectangle.MarginProperty, new Thickness(20F));
            pl_s.Setters.Add(pl_s_S_5);
            Setter pl_s_S_6 = new Setter(Rectangle.StrokeProperty, new SolidColorBrush(new ColorW(128, 128, 128, 255)));
            pl_s.Setters.Add(pl_s_S_6);
            Setter pl_s_S_7 = new Setter(Rectangle.StrokeThicknessProperty, 1F);
            pl_s.Setters.Add(pl_s_S_7);
            EventTrigger pl_s_ET_0 = new EventTrigger(Rectangle.MouseEnterEvent);
            pl_s.Triggers.Add(pl_s_ET_0);
            BeginStoryboard pl_s_ET_0_AC_0 = new BeginStoryboard();
            pl_s_ET_0_AC_0.Name = "pl_s_ET_0_AC_0";
            pl_s_ET_0.AddAction(pl_s_ET_0_AC_0);
            Storyboard pl_s_ET_0_AC_0_SB = new Storyboard();
            pl_s_ET_0_AC_0.Storyboard = pl_s_ET_0_AC_0_SB;
            pl_s_ET_0_AC_0_SB.Name = "pl_s_ET_0_AC_0_SB";
            ThicknessAnimation pl_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            pl_s_ET_0_AC_0_SB_TL_0.Name = "pl_s_ET_0_AC_0_SB_TL_0";
            pl_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            pl_s_ET_0_AC_0_SB_TL_0.From = new Thickness(20F, 20F, 20F, 20F);
            pl_s_ET_0_AC_0_SB_TL_0.To = new Thickness(10F, 10F, 10F, 10F);
            SineEase pl_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            pl_s_ET_0_AC_0_SB_TL_0.EasingFunction = pl_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(pl_s_ET_0_AC_0_SB_TL_0, Rectangle.MarginProperty);
            pl_s_ET_0_AC_0_SB.Children.Add(pl_s_ET_0_AC_0_SB_TL_0);
            EventTrigger pl_s_ET_1 = new EventTrigger(Rectangle.MouseLeaveEvent);
            pl_s.Triggers.Add(pl_s_ET_1);
            BeginStoryboard pl_s_ET_1_AC_0 = new BeginStoryboard();
            pl_s_ET_1_AC_0.Name = "pl_s_ET_1_AC_0";
            pl_s_ET_1.AddAction(pl_s_ET_1_AC_0);
            Storyboard pl_s_ET_1_AC_0_SB = new Storyboard();
            pl_s_ET_1_AC_0.Storyboard = pl_s_ET_1_AC_0_SB;
            pl_s_ET_1_AC_0_SB.Name = "pl_s_ET_1_AC_0_SB";
            ThicknessAnimation pl_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            pl_s_ET_1_AC_0_SB_TL_0.Name = "pl_s_ET_1_AC_0_SB_TL_0";
            pl_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            pl_s_ET_1_AC_0_SB_TL_0.From = new Thickness(10F, 10F, 10F, 10F);
            pl_s_ET_1_AC_0_SB_TL_0.To = new Thickness(20F, 20F, 20F, 20F);
            SineEase pl_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            pl_s_ET_1_AC_0_SB_TL_0.EasingFunction = pl_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(pl_s_ET_1_AC_0_SB_TL_0, Rectangle.MarginProperty);
            pl_s_ET_1_AC_0_SB.Children.Add(pl_s_ET_1_AC_0_SB_TL_0);
            this.pl.Style = pl_s;
            ImageBrush pl_Fill = new ImageBrush();
            BitmapImage pl_Fill_bm = new BitmapImage();
            pl_Fill_bm.TextureAsset = "Images/pl";
            pl_Fill.ImageSource = pl_Fill_bm;
            pl_Fill.Stretch = Stretch.Fill;
            this.pl.Fill = pl_Fill;
            Grid.SetColumn(this.pl, 0);
            Grid.SetRow(this.pl, 3);
            // en element
            this.en = new Rectangle();
            this.e_0.Children.Add(this.en);
            this.en.Name = "en";
            Style en_s = new Style(typeof(Rectangle));
            Setter en_s_S_0 = new Setter(Rectangle.SnapsToDevicePixelsProperty, false);
            en_s.Setters.Add(en_s_S_0);
            Setter en_s_S_1 = new Setter(Rectangle.HorizontalAlignmentProperty, HorizontalAlignment.Stretch);
            en_s.Setters.Add(en_s_S_1);
            Setter en_s_S_2 = new Setter(Rectangle.VerticalAlignmentProperty, VerticalAlignment.Stretch);
            en_s.Setters.Add(en_s_S_2);
            Setter en_s_S_3 = new Setter(Rectangle.RadiusXProperty, 10F);
            en_s.Setters.Add(en_s_S_3);
            Setter en_s_S_4 = new Setter(Rectangle.RadiusYProperty, 10F);
            en_s.Setters.Add(en_s_S_4);
            Setter en_s_S_5 = new Setter(Rectangle.MarginProperty, new Thickness(20F));
            en_s.Setters.Add(en_s_S_5);
            Setter en_s_S_6 = new Setter(Rectangle.StrokeProperty, new SolidColorBrush(new ColorW(128, 128, 128, 255)));
            en_s.Setters.Add(en_s_S_6);
            Setter en_s_S_7 = new Setter(Rectangle.StrokeThicknessProperty, 1F);
            en_s.Setters.Add(en_s_S_7);
            EventTrigger en_s_ET_0 = new EventTrigger(Rectangle.MouseEnterEvent);
            en_s.Triggers.Add(en_s_ET_0);
            BeginStoryboard en_s_ET_0_AC_0 = new BeginStoryboard();
            en_s_ET_0_AC_0.Name = "en_s_ET_0_AC_0";
            en_s_ET_0.AddAction(en_s_ET_0_AC_0);
            Storyboard en_s_ET_0_AC_0_SB = new Storyboard();
            en_s_ET_0_AC_0.Storyboard = en_s_ET_0_AC_0_SB;
            en_s_ET_0_AC_0_SB.Name = "en_s_ET_0_AC_0_SB";
            ThicknessAnimation en_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            en_s_ET_0_AC_0_SB_TL_0.Name = "en_s_ET_0_AC_0_SB_TL_0";
            en_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            en_s_ET_0_AC_0_SB_TL_0.From = new Thickness(20F, 20F, 20F, 20F);
            en_s_ET_0_AC_0_SB_TL_0.To = new Thickness(10F, 10F, 10F, 10F);
            SineEase en_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            en_s_ET_0_AC_0_SB_TL_0.EasingFunction = en_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(en_s_ET_0_AC_0_SB_TL_0, Rectangle.MarginProperty);
            en_s_ET_0_AC_0_SB.Children.Add(en_s_ET_0_AC_0_SB_TL_0);
            EventTrigger en_s_ET_1 = new EventTrigger(Rectangle.MouseLeaveEvent);
            en_s.Triggers.Add(en_s_ET_1);
            BeginStoryboard en_s_ET_1_AC_0 = new BeginStoryboard();
            en_s_ET_1_AC_0.Name = "en_s_ET_1_AC_0";
            en_s_ET_1.AddAction(en_s_ET_1_AC_0);
            Storyboard en_s_ET_1_AC_0_SB = new Storyboard();
            en_s_ET_1_AC_0.Storyboard = en_s_ET_1_AC_0_SB;
            en_s_ET_1_AC_0_SB.Name = "en_s_ET_1_AC_0_SB";
            ThicknessAnimation en_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            en_s_ET_1_AC_0_SB_TL_0.Name = "en_s_ET_1_AC_0_SB_TL_0";
            en_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            en_s_ET_1_AC_0_SB_TL_0.From = new Thickness(10F, 10F, 10F, 10F);
            en_s_ET_1_AC_0_SB_TL_0.To = new Thickness(20F, 20F, 20F, 20F);
            SineEase en_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            en_s_ET_1_AC_0_SB_TL_0.EasingFunction = en_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(en_s_ET_1_AC_0_SB_TL_0, Rectangle.MarginProperty);
            en_s_ET_1_AC_0_SB.Children.Add(en_s_ET_1_AC_0_SB_TL_0);
            this.en.Style = en_s;
            ImageBrush en_Fill = new ImageBrush();
            BitmapImage en_Fill_bm = new BitmapImage();
            en_Fill_bm.TextureAsset = "Images/en";
            en_Fill.ImageSource = en_Fill_bm;
            en_Fill.Stretch = Stretch.Fill;
            this.en.Fill = en_Fill;
            Grid.SetColumn(this.en, 1);
            Grid.SetRow(this.en, 3);
            // de element
            this.de = new Rectangle();
            this.e_0.Children.Add(this.de);
            this.de.Name = "de";
            Style de_s = new Style(typeof(Rectangle));
            Setter de_s_S_0 = new Setter(Rectangle.SnapsToDevicePixelsProperty, false);
            de_s.Setters.Add(de_s_S_0);
            Setter de_s_S_1 = new Setter(Rectangle.HorizontalAlignmentProperty, HorizontalAlignment.Stretch);
            de_s.Setters.Add(de_s_S_1);
            Setter de_s_S_2 = new Setter(Rectangle.VerticalAlignmentProperty, VerticalAlignment.Stretch);
            de_s.Setters.Add(de_s_S_2);
            Setter de_s_S_3 = new Setter(Rectangle.RadiusXProperty, 10F);
            de_s.Setters.Add(de_s_S_3);
            Setter de_s_S_4 = new Setter(Rectangle.RadiusYProperty, 10F);
            de_s.Setters.Add(de_s_S_4);
            Setter de_s_S_5 = new Setter(Rectangle.MarginProperty, new Thickness(20F));
            de_s.Setters.Add(de_s_S_5);
            Setter de_s_S_6 = new Setter(Rectangle.StrokeProperty, new SolidColorBrush(new ColorW(128, 128, 128, 255)));
            de_s.Setters.Add(de_s_S_6);
            Setter de_s_S_7 = new Setter(Rectangle.StrokeThicknessProperty, 1F);
            de_s.Setters.Add(de_s_S_7);
            EventTrigger de_s_ET_0 = new EventTrigger(Rectangle.MouseEnterEvent);
            de_s.Triggers.Add(de_s_ET_0);
            BeginStoryboard de_s_ET_0_AC_0 = new BeginStoryboard();
            de_s_ET_0_AC_0.Name = "de_s_ET_0_AC_0";
            de_s_ET_0.AddAction(de_s_ET_0_AC_0);
            Storyboard de_s_ET_0_AC_0_SB = new Storyboard();
            de_s_ET_0_AC_0.Storyboard = de_s_ET_0_AC_0_SB;
            de_s_ET_0_AC_0_SB.Name = "de_s_ET_0_AC_0_SB";
            ThicknessAnimation de_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            de_s_ET_0_AC_0_SB_TL_0.Name = "de_s_ET_0_AC_0_SB_TL_0";
            de_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            de_s_ET_0_AC_0_SB_TL_0.From = new Thickness(20F, 20F, 20F, 20F);
            de_s_ET_0_AC_0_SB_TL_0.To = new Thickness(10F, 10F, 10F, 10F);
            SineEase de_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            de_s_ET_0_AC_0_SB_TL_0.EasingFunction = de_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(de_s_ET_0_AC_0_SB_TL_0, Rectangle.MarginProperty);
            de_s_ET_0_AC_0_SB.Children.Add(de_s_ET_0_AC_0_SB_TL_0);
            EventTrigger de_s_ET_1 = new EventTrigger(Rectangle.MouseLeaveEvent);
            de_s.Triggers.Add(de_s_ET_1);
            BeginStoryboard de_s_ET_1_AC_0 = new BeginStoryboard();
            de_s_ET_1_AC_0.Name = "de_s_ET_1_AC_0";
            de_s_ET_1.AddAction(de_s_ET_1_AC_0);
            Storyboard de_s_ET_1_AC_0_SB = new Storyboard();
            de_s_ET_1_AC_0.Storyboard = de_s_ET_1_AC_0_SB;
            de_s_ET_1_AC_0_SB.Name = "de_s_ET_1_AC_0_SB";
            ThicknessAnimation de_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            de_s_ET_1_AC_0_SB_TL_0.Name = "de_s_ET_1_AC_0_SB_TL_0";
            de_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            de_s_ET_1_AC_0_SB_TL_0.From = new Thickness(10F, 10F, 10F, 10F);
            de_s_ET_1_AC_0_SB_TL_0.To = new Thickness(20F, 20F, 20F, 20F);
            SineEase de_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            de_s_ET_1_AC_0_SB_TL_0.EasingFunction = de_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(de_s_ET_1_AC_0_SB_TL_0, Rectangle.MarginProperty);
            de_s_ET_1_AC_0_SB.Children.Add(de_s_ET_1_AC_0_SB_TL_0);
            this.de.Style = de_s;
            ImageBrush de_Fill = new ImageBrush();
            BitmapImage de_Fill_bm = new BitmapImage();
            de_Fill_bm.TextureAsset = "Images/de";
            de_Fill.ImageSource = de_Fill_bm;
            de_Fill.Stretch = Stretch.Fill;
            this.de.Fill = de_Fill;
            Grid.SetColumn(this.de, 2);
            Grid.SetRow(this.de, 3);
            // apply element
            this.apply = new Button();
            this.e_0.Children.Add(this.apply);
            this.apply.Name = "apply";
            Grid.SetColumn(this.apply, 1);
            Grid.SetRow(this.apply, 2);
            // e_3 element
            this.e_3 = new TextBlock();
            this.apply.Content = this.e_3;
            this.e_3.Name = "e_3";
            Binding binding_e_3_Text = new Binding("Apply");
            binding_e_3_Text.FallbackValue = "Apply";
            this.e_3.SetBinding(TextBlock.TextProperty, binding_e_3_Text);
            ImageManager.Instance.AddImage("Images/pl");
            ImageManager.Instance.AddImage("Images/en");
            ImageManager.Instance.AddImage("Images/de");
            FontManager.Instance.AddFont("Segoe UI", 80F, FontStyle.Regular, "Segoe_UI_60_Regular");
            FontManager.Instance.AddFont("Segoe UI", 50F, FontStyle.Regular, "Segoe_UI_37.5_Regular");
        }
        
        private static void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
    }
}

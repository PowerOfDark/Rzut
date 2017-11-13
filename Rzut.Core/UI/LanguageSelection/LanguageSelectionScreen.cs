using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface.Generated;
using tainicom.Aether.Physics2D.Samples.ScreenSystem;
using Rzut.Core.UI;
using EmptyKeys.UserInterface.Media;
using EmptyKeys.UserInterface.Shapes;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Rzut.Core.UI.DataEntry;
using Rzut.Interface.Data.i18n;
using Rzut.Interface.Data;
using Rzut.Interface.Data.ViewModels.LanguageSelection;

namespace Rzut.Core.Screens
{
    public class LanguageSelectionScreen : GameScreen
    {
        LanguageSelection Form;
        public override void Draw(GameTime gameTime)
        {
            Form.Draw(gameTime.ElapsedGameTime.TotalMilliseconds);
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {
            //UserInterface.Active.Update(gameTime);
            Form.UpdateInput(gameTime.ElapsedGameTime.TotalMilliseconds);
            Form.UpdateLayout(gameTime.ElapsedGameTime.TotalMilliseconds);

            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        }

        public override void LoadContent()
        {
            base.LoadContent();

            var font = ScreenManager.Content.Load<SpriteFont>("UI/Segoe_UI_30_Regular");
            FontManager.DefaultFont = Engine.Instance.Renderer.CreateFont(font);

            var viewport = ScreenManager.GraphicsDevice.Viewport;
            Form = new LanguageSelection(viewport.Width, viewport.Height) { DataContext = new LanguageSelectionContext() };

            FontManager.Instance.LoadFonts(ScreenManager.Content, "UI/");
            ImageManager.Instance.LoadImages(ScreenManager.Content, "UI/");

            foreach(var lang in InternationalizationHelper.SupportedLanguages)
            {
                if(VisualTreeHelper.Instance.FindElementByName(Form, lang) is EmptyKeys.UserInterface.Shapes.Rectangle r)
                {
                    r.MouseDown += (s, e) => LanguageClick(s);
                    r.TouchDown += (s, e) => LanguageClick(s);
                }
            }
            var btn = (Button)VisualTreeHelper.Instance.FindElementByName(Form, "apply");
            btn.Click += Btn_Click;


        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            ExitScreen();
            ScreenManager.AddScreen(new DataEntryScreen());
        }

        private void LanguageClick(object sender)
        {
            var r = (EmptyKeys.UserInterface.Shapes.Rectangle)sender;
            InternationalizationHelper.Set(r.Name);
            (Form.DataContext as LanguageSelectionContext).Update();
        }

        public override void HandleInput(InputHelper input, GameTime gameTime)
        {
            if (input.IsNewButtonPress(Buttons.Back) || input.IsNewKeyPress(Keys.Escape))
                ExitScreen();
            base.HandleInput(input, gameTime);
        }
    }
}

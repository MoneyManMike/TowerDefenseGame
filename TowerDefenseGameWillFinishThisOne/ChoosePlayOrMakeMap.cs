﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MichaelLibrary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefenseGameWillFinishThisOne
{
    public class ChoosePlayOrMakeMap : Screen
    {
        Sprite ChoiceSprite;
        Button MakeMapButton;

        public ChoosePlayOrMakeMap(GraphicsDevice graphics, ContentManager content) 
            :base(graphics, content)
        {
            ChoiceSprite = new Sprite(Content.Load<Texture2D>("ChoicesSprite"), new Vector2(graphics.Viewport.Width / 2, graphics.Viewport.Height / 2), Color.White, new Vector2(Main.SpriteScales["ChoicesSprite"] * Main.ScreenScale), null);
            MakeMapButton = new Button(Content.Load<Texture2D>("MakeMapButton"), ChoiceSprite.Position + new Vector2(-300, -247) * Main.ScreenScale, Color.White, new Vector2(Main.SpriteScales["MakeMapButton"] * Main.ScreenScale), null);

            Sprites.Add(Main.Background);
            Sprites.Add(Main.Tint);
            Sprites.Add(ChoiceSprite);
            Sprites.Add(MakeMapButton);
        }

        public override void Update(GameTime gameTime)
        {
            if (MakeMapButton.IsClicked(Main.mouse) && !MakeMapButton.IsClicked(Main.oldMouse))
            {
                Main.CurrentScreen = ScreenStates.MakeMap;
                Main.ScreenCameFrom = ScreenStates.ChoosePlayOrMakeMap;
            }
            base.Update(gameTime);
        }

    }
}
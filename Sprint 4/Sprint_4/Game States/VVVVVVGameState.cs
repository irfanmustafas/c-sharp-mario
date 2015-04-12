﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint4
{
    class VVVVVVGameState :IGameState
    {
        Game1 game;

        public VVVVVVGameState()
        {
            game = Game1.GetInstance();
            game.level.mario.physState = new VVVVVVPhysState();
            game.keyboardController = new VVVVVVKeyController(game.level.mario);
            game.gamepadController = new VVVVVVPadController(game.level.mario);
            game.gameHUD.PausedCheck = false;
            game.gameHUD.gameEnded = false;
            game.isVVVVVV = true;
        }
        public void Update(GameTime gameTime)
        {
            game.keyboardController.Update();
            game.gamepadController.Update();
            game.level.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            game.level.Draw(spriteBatch);
        }
    }
}

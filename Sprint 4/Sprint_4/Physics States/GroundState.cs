﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint4
{
    public class GroundState :IMarioPhysicsState
    {
        Game1 game;
        public Vector2 speedDecayRate = new Vector2((float)0.80, (float)0.80);
        public GroundState(Mario mario, Game1 game)
        {
            this.game = game;
            mario.Land();
            mario.velocity.Y = 0; 
        }
        public void Update(Mario mario, GameTime gameTime)
        {
            mario.position += mario.velocity * ((float)gameTime.ElapsedGameTime.Milliseconds / (float)40.0);
            mario.velocity *= speedDecayRate;
            mario.velocity.Y = 0;
            if (game.level.collision.standingBlocks.Count == 0)
            {
                mario.physState = new FallingState(game);
            } 
        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadMiner.Building
{
    class Tower
    {
        protected int cost;//how much the tower cost to build
        protected int damage;//damage the tower does to the enemy
        protected float radius;//how big range the tower has
        
        
        protected Enemies.Enemy target; //shows whitch enemy to shoot
        

        /// <summary>
        /// stats of the towers
        /// </summary>
        /// <param name="frameCount"></param>
        /// <param name="animationFPS"></param>
        /// <param name="textureName"></param>
        /// <param name="content"></param>
        /// <param name="position"></param>
        /// <param name="bulletTexture"></param>
        public Tower(string textureName, ContentManager content, Vector2 position)
        {
            radius = 200;
            damage = 5;
            cost = 90;
            

        }
        /// <summary>
        /// allows the tower to have a target 
        /// </summary>
        public Enemies.Enemy Target
        {
            get { return target; }
        }
        
        
        /// <summary>
        /// the tower cost cookies to build
        /// </summary>
        public int Cost
        {
            get { return cost; }
        }
        /// <summary>
        /// allows the tower to do some damage
        /// </summary>
        public int Damage
        {
            get { return damage; }
        }
        /// <summary>
        /// the radius of the towers
        /// </summary>
        public float Radius
        {
            get { return radius; }
        }
        
       
    }

    
}

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Edge
{
    public class MyPlayer : ModPlayer
    {
        public override void SetupStartInventory(IList<Item> items)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("TheEndBook"));
            item.stack = 5;
            items.Add(item);
        }
            private const int saveVersion = 0;
            public bool Duck = false;
            public static bool hasProjectile;

            public override void ResetEffects()
            {
                Duck = false;
            }
        }
    }


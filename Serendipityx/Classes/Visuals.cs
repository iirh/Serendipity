using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Serendipityx.Classes
{
    class Visuals
    {
        public static void Start()
        {
            while (true)
            {
                if (Main.S.VisualsEnabled)
                {
                    foreach (Entity Player in Globals.EntityList)
                    {
                        if (Player.Valid)
                        {
                            if (Player.IsTeammate)
                            {
                                if (Main.S.GlowEnabled && Main.S.GlowTeam)
                                    Player.Glow(Main.S.GlowTeamColor);
                                if (Main.S.ChamsEnabled)
                                {
                                    if (Main.S.ChamTeam)
                                        Player.Cham(Main.S.ChamTeamColor);
                                }
                            }
                            else
                            {
                                if (Main.S.GlowEnabled)
                                {
                                    if (Main.S.GlowHealth)
                                    {
                                        // Health Gradient math by: MultiHackerCoun (unknowncheats)
                                        Color Gradient = Tools.HealthGradient(Tools.HealthToPercent(Player.Health));
                                        Player.Glow(Color.FromArgb(Gradient.R, Gradient.G, Gradient.B));
                                    }
                                    else
                                    {
                                        Player.Glow(Main.S.GlowEnemyColor);
                                    }
                                }

                                if (Main.S.ChamsEnabled)
                                {
                                    if (Main.S.ChamHealth)
                                    {
                                        Color Gradient = Tools.HealthGradient(Tools.HealthToPercent(Player.Health));
                                        Player.Cham(Color.FromArgb(Gradient.R, Gradient.G, Gradient.B));
                                    }
                                    else
                                    {
                                        Player.Cham(Main.S.ChamEnemyColor);
                                    }
                                }


                            }


                        }
                    }
                }
                Thread.Sleep(1);
            }
            
        }
    }
}

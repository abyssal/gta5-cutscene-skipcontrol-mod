using System;
using System.Windows.Forms;
using GTA;

namespace ChaosMod
{
	public class BlockCutsceneSkips : Script
	{
		public BlockCutsceneSkips()
		{
			this.Tick += OnTick;
		}

		private void OnTick(object sender, EventArgs e)
		{
			if (Game.IsKeyPressed(Keys.K))
            {
				GTA.Native.Function.Call(GTA.Native.Hash.STOP_CUTSCENE);
            } else
            {
				Game.DisableControlThisFrame(GTA.Control.SkipCutscene);
			}
		}
	}
}

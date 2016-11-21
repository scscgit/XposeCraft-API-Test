﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XposeCraft_UI_API_Prototype_Test.Game.Control.GameActions;

namespace XposeCraft_UI_API_Prototype_Test.Game.Control
{
	public class UnitActionQueue
	{
		Queue<IGameAction> Queue = new Queue<IGameAction>();

		public UnitActionQueue()
		{
		}

		public UnitActionQueue(IGameAction action)
		{
			After(action);
		}

		public UnitActionQueue After(IGameAction action)
		{
			Queue.Enqueue(action);
			return this;
		}
	}
}
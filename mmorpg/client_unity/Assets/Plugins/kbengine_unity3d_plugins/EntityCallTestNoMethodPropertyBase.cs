/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/TestNoMethodProperty.def
	public class EntityBaseEntityCall_TestNoMethodPropertyBase : EntityCall
	{
		public UInt16 entityComponentPropertyID = 0;

		public EntityBaseEntityCall_TestNoMethodPropertyBase(UInt16 ecpID, Int32 eid) : base(eid, "TestNoMethodProperty")
		{
			entityComponentPropertyID = ecpID;
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

	}

	public class EntityCellEntityCall_TestNoMethodPropertyBase : EntityCall
	{
		public UInt16 entityComponentPropertyID = 0;

		public EntityCellEntityCall_TestNoMethodPropertyBase(UInt16 ecpID, Int32 eid) : base(eid, "TestNoMethodProperty")
		{
			entityComponentPropertyID = ecpID;
			className = "TestNoMethodProperty";
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

	}
	}
﻿using UnityEngine;
using System.Collections;
namespace GDGeek{
	public interface IVoxelBuilder{

		void build(VoxelProduct product);
		Task task(VoxelProduct product);

		//public abstract Task task (VoxelProduct product);
	}
}
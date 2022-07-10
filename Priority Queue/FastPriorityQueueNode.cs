﻿using System;

namespace Priority_Queue
{
	public class FastPriorityQueueNode<TPriority>
	{
		/// <summary>
		/// The Priority to insert this node at.
		/// Cannot be manually edited - see queue.Enqueue() and queue.UpdatePriority() instead
		/// </summary>
		public TPriority Priority { get; protected internal set; }

		/// <summary>
		/// Represents the current position in the queue
		/// </summary>
		public int QueueIndex { get; internal set; }

#if DEBUG
		/// <summary>
		/// The queue this node is tied to. Used only for debug builds.
		/// </summary>
		public object Queue { get; internal set; }
#endif
	}

	public class FastPriorityQueueNode : FastPriorityQueueNode<float>
	{
	}
}

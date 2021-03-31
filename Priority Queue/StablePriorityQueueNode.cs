namespace Priority_Queue
{
    public class StablePriorityQueueNode<TPriority> : FastPriorityQueueNode<TPriority>
    {
        /// <summary>
        /// Represents the order the node was inserted in
        /// </summary>
        public long InsertionIndex { get; internal set; }
    }


    public class StablePriorityQueueNode : StablePriorityQueueNode<float>
    {
    }
}

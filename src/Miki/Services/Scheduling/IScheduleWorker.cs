﻿namespace Miki.Services.Scheduling
{
    using System;
    using System.Threading.Tasks;

    public interface IScheduleWorker
    {
        /// <summary>
        /// Cancels a task if exists. Cannot delete owned tasks without the owner ID. Unowned tasks
        /// should pass only an UUID.
        /// </summary>
        Task CancelTaskAsync(string uuid, string ownerId = null);

        /// <summary>
        /// Queues a task.
        /// </summary>
        Task QueueTaskAsync(TimeSpan duration, string json, string ownerId, bool isRepeating = false);
    }
}
﻿namespace SoundFingerprinting.Query.Configuration
{
    public class DefaultQueryConfiguration : IQueryConfiguration
    {
        public DefaultQueryConfiguration()
        {
            NumberOfLSHTables = 25;
            NumberOfMinHashesPerTable = 4;
            ThresholdVotes = 5;
        }

        public int NumberOfLSHTables { get; private set; }

        public int NumberOfMinHashesPerTable { get; private set; }

        public int ThresholdVotes { get; private set; }
    }
}

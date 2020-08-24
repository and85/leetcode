using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Twitter
    {
        static int TweetTimeStamp = 0;
        // to reduce space it makes sense to store only 10 last tweets in stack
        class Tweet
        { 
            public Tweet (int tweetId, int counter)
            {
                TweetId = tweetId;
                Timestamp = counter;
            }

            public int TweetId { get; private set; }
            public int Timestamp { get; private set; }
        }

        private Dictionary<int, Stack<Tweet>> _tweets;
        private Dictionary<int, List<int>> _followers;

        /** Initialize your data structure here. */
        public Twitter()
        {
            _tweets = new Dictionary<int, Stack<Tweet>>();
            _followers = new Dictionary<int, List<int>>();
        }

        /** Compose a new tweet. */
        public void PostTweet(int userId, int tweetId)
        {
            // O(1)
            if (!_tweets.ContainsKey(userId))
                _tweets.Add(userId, new Stack<Tweet>());

            //if (!_tweets[userId].Contains(t => t.))
                _tweets[userId].Push(new Tweet(tweetId, ++TweetTimeStamp));
        }

        /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
        public IList<int> GetNewsFeed(int userId)
        {
            var result = new List<int>();
            int prevMax = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                Tweet tweet = GetGreatestTweet(userId, prevMax, out bool tweetFound);
                if (tweetFound)
                {
                    prevMax = tweet.Timestamp;
                    if (!result.Contains(tweet.TweetId))
                        result.Add(tweet.TweetId);
                }
            }

            return result;
        }

        private Tweet GetGreatestTweet(int userId, int maxValue, out bool tweetFound )
        {
            Tweet maxCandidate = new Tweet(0, maxValue);

            tweetFound = false;
            if (_tweets.ContainsKey(userId))
            {
                foreach (Tweet tweet in _tweets[userId])
                {
                    // we need to check only one tweet which is less than max value
                    if (tweet.Timestamp < maxValue)
                    {
                        tweetFound = true;
                        maxCandidate = tweet;
                        break;
                    }
                }
            }

            if (_followers.ContainsKey(userId))
            {
                foreach (int followee in _followers[userId])
                {
                    // we need to check only one tweet which is less than max value
                    if (_tweets.ContainsKey(followee))
                    {
                        foreach (Tweet tweet in _tweets[followee])
                        {
                            if (tweet.Timestamp < maxValue &&
                                ((tweet.Timestamp > maxCandidate.Timestamp && tweetFound) || !tweetFound)
                                )
                            {
                                tweetFound = true;
                                maxCandidate = tweet;
                                break;
                            }
                        }
                    }
                }
            }

            return maxCandidate;
        }

        /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
        public void Follow(int followerId, int followeeId)
        {
            // O(1)
            if(!_followers.ContainsKey(followerId))
                _followers.Add(followerId, new List<int>());

            if (!_followers[followerId].Contains(followeeId))
                _followers[followerId].Add(followeeId);
        }

        /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
        public void Unfollow(int followerId, int followeeId)
        {
            if (_followers.ContainsKey(followerId))
                _followers[followerId].Remove(followeeId);
        }
    }

    /**
    * Your Twitter object will be instantiated and called as such:
    * Twitter obj = new Twitter();
    * obj.PostTweet(userId,tweetId);
    * IList<int> param_2 = obj.GetNewsFeed(userId);
    * obj.Follow(followerId,followeeId);
    * obj.Unfollow(followerId,followeeId);
    */
}

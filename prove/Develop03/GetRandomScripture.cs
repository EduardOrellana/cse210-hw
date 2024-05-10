using System.Collections.Generic;

public class GetRandomScripture 
{
    //This class will containg random scritpures.

    private Dictionary<int, Scripture> _scriptures = new Dictionary<int, Scripture>()
    {
        {1, new Scripture(new Reference("John", 3,16), @"For God so loved the world")},

        {2, new Scripture(new Reference("3 Nephi", 5, 13), @"Behold, I am a disciple of JesusChrist, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life.")},

        {3, new Scripture(new Reference("Moroni", 10,3,5), @"Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts.

        And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.

        And by the power of the Holy Ghost ye may aknow the truth of all things.")},

        {4, new Scripture(new Reference("Joshua", 1, 9), @"Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.")}
    };
}
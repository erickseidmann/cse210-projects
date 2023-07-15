using System;
using System.Collections.Generic;

namespace DiaryApp
{
    class Scriptures
    {
        private List<string> motivationalScriptures;

        public Scriptures()
        {
            motivationalScriptures = new List<string>()
            {
                "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.(1Nephi 3:7)",
                "11 Do ye not remember the things which the Lord hath said?—If ye will not harden your hearts, and aask me in bfaith, believing that ye shall receive, with diligence in keeping my commandments, surely these things shall be made known unto you.(1Nephi 15:11)",
                "28 Awake, my soul! No longer adroop in sin. Rejoice, O my heart, and give place no more for the benemy of my soul.(2Nephi 4:28)",
                "Verily I say unto you all: aArise and shine forth, that thy blight may be a cstandard for the dnations;(D&C 115:05)",
                "And again, be apatient in tribulation until I bcome; and, behold, I come quickly, and my creward is with me, and they who have dsought me early shall find erest to their souls. Even so. Amen.(D&C 54:10)"
            };
        }

        public string GetRandomMotivationalScripture()
        {
            Random random = new Random();
            int index = random.Next(motivationalScriptures.Count);
            return motivationalScriptures[index];
        }
    }
}
